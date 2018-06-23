import argparse
import os


args = None


def list_files_and_directories_in_folder(folder):
    return os.listdir(folder)


# see https://docs.unity3d.com/Manual/SpecialFolders.html for including rules in unity
def should_ignore(path):
    if path.startswith('.') or path.endswith('~') or path == 'cvs' or path.endswith('.tmp'):
        return True

    return False


def check_metafiles_in_package(package_folder):
    root_files = list_files_and_directories_in_folder(package_folder)
    success = True
    for file in root_files:
        if should_ignore(file):
            continue

        combined_path = os.path.join(package_folder, file)
        if os.path.isdir(combined_path):
            success = check_metafiles_in_package(combined_path) & success
        if file.endswith("meta") and file[:-5] not in root_files:
            print '{0} is a dangling meta file. Please remove it'.format(
                combined_path, package_folder)
            success = False
        if not file.endswith("meta") and not file + ".meta" in root_files:
            print "{0} doesn't have a meta file. Please add one".format(
                combined_path, package_folder)
            success = False
    return success


def main():
    for package in args.package_path:
        if not check_metafiles_in_package(package):
            raise Exception


def parse_argument_list():
    parser = argparse.ArgumentParser(description="A tool which performs sanity checks against the packages and demo "
                                                 "that are going to be tested published in the next CI steps.")

    parser.add_argument('--package-path', action='append', required=True,
                        help="Path to where the package exists. It should be a folder "
                             "where there exists a package.json")

    return parser.parse_args()


if __name__ == "__main__":
    args = parse_argument_list()
    main()
