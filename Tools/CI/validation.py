import argparse
import datetime
import os
import json
import re

args = None


def list_files_and_directories_in_folder(folder):
    return os.listdir(folder)


# see https://docs.unity3d.com/Manual/SpecialFolders.html for including rules in unity
def should_ignore(path):
    if path.startswith('.') or path.endswith('~') or path == 'cvs' or path.endswith('.tmp'):
        return True

    return False


def check_metafiles_in_package(package_path):
    if not os.path.exists(package_path):
        raise Exception("The package specified {0} does not exist.".format(package_path))
    root_files = list_files_and_directories_in_folder(package_path)
    success = True
    for file in root_files:
        if should_ignore(file):
            continue

        combined_path = os.path.join(package_path, file)
        if os.path.isdir(combined_path):
            success = check_metafiles_in_package(combined_path) & success
        if file.endswith("meta") and file[:-5] not in root_files:
            print '{0} is a dangling meta file. Please remove it'.format(
                combined_path, package_path)
            success = False
        if not file.endswith("meta") and not file + ".meta" in root_files:
            print "{0} doesn't have a meta file. Please add one".format(
                combined_path, package_path)
            success = False
    return success


def check_changelog(package_path):
    changelog_path = os.path.join(package_path, "changelog.md")
    if not os.path.exists(changelog_path):
        raise Exception("Please provide a changelog file for this package.")

    with open(changelog_path) as f:
        text = f.read().splitlines()

    text = filter(None, text)

    if text[0] != "# Changelog":
        raise Exception("Bad Format in changelog file. Check whether the document starts with '# Changelog'.")

    if args.commit_tag not in text[1]:
        raise Exception("Update the changelog listing the latest changes for the version {0} of the package.".format(args.commit_tag))

    if text[1].strip() != "## [{0}] - {1}".format(args.commit_tag, datetime.datetime.today().strftime('%Y-%m-%d')):
        raise Exception("The changelog may contain a temporary list of changes. Please specify the version as [{0}] - {1}".format(args.commit_tag, datetime.datetime.today().strftime('%Y-%m-%d')))

    if not text[2].startswith('- '):
        raise Exception("Add at least one item to the list of changes for the version {0}. Please note that the list is "
                        "required to be a bulletpoint list (each item needs to start with '- '.".format(args.commit_tag))


def check_version(package_path):
    tag_version = args.commit_tag
    json_path = os.path.join(package_path, 'package.json')
    if not os.path.exists(json_path):
        raise Exception("This is not a valid npm package. File package.json is missing")
    with open(json_path, 'r') as f:
        package_version = json.load(f)['version']
    if not tag_version == package_version:
        raise Exception("The tag {0} specified does not match with the package tag {1}. "
                        "Did you update the version in {2}?".format(tag_version, package_version, package_path))


def main():
    for package in args.package_path:
        if not check_metafiles_in_package(package):
            raise Exception

        check_version(package)

        check_changelog(package)



def parse_argument_list():
    parser = argparse.ArgumentParser(description="A tool which performs sanity checks against the package that is going "
                                                 "to be published in the current CI step.")

    parser.add_argument('--package-path', action='append', required=True,
                        help="Path to where the package exists. It should be a folder "
                             "where a package.json file exists")

    parser.add_argument('--commit-tag', required=True, help="Version of the package to publish. ")

    return parser.parse_args()


if __name__ == "__main__":
    args = parse_argument_list()
    # Remove `exp.` prefix from commit_tag
    args.commit_tag = re.sub(r'^exp\.(.*)', r'\1', args.commit_tag)
    main()
