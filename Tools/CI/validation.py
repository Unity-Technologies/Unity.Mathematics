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
    for file in root_files:
        if should_ignore(file):
            continue

        if os.path.isdir(file):
            check_metafiles_in_package(file)

        if not file.endswith("meta") and not file + ".meta" in root_files:
            raise Exception(
                'Missing {0}.meta in package {1}. Packages require every file and directory to have a meta file associated.'.format(
                    file, package_folder))

    return True


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
