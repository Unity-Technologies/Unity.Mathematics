import os
import sys

import utils

artifactory_api_url = "https://artifactory.eu-cph-1.unityops.net"
artifactory_api_repository = "core-automation"
artifactory_download_url = "https://bfartifactory.bf.unity3d.com/artifactory/ie-generic-core-automation"
bokken_artifactory_cache_url = "http://172.28.214.140/"
build_version = '2018.2.*&latest=true'

def download_unity_launcher(type):
    if not os.path.exists(".tmp"):
        os.mkdir(".tmp")
    download_url = artifactory_download_url
    if 'USE_UBERBUCKET' in os.environ:
        download_url = bokken_artifactory_cache_url
    utils.download_url("%s/tools/unity-launcher/UnityLauncher.%s.zip" % (download_url, type),
                       ".tmp/UnityLauncher.%s.zip" % type)


def extract_unity_launcher(type):
    utils.extract_zip(".tmp/UnityLauncher.%s.zip" % type,
                      ".UnityLauncher.%s" % type)
    current_os = utils.get_current_os()
    if current_os == "macOS":
        os.chmod('.UnityLauncher.{0}/osx.10.12-x64/publish/UnityLauncher.{0}'.format(type), 0755)
    elif current_os == "linux":
        os.chmod('.UnityLauncher.{0}/linux-x64/publish/UnityLauncher.{0}'.format(type), 0755)


def prepare_unity_launcher(run_type):

    download_unity_launcher(run_type)
    extract_unity_launcher(run_type)

def main():
    prepare_unity_launcher("Editor")
    return


if __name__ == "__main__":
    main()
