#!/usr/bin/python -B
import os
import logging

def packages_list():
    return [
        ("com.unity.mathematics", os.path.join("src"))
    ]

def test_packages_list():
    return [
    ]

if __name__ == "__main__":
    import sys
    sys.path.insert(0, os.path.abspath(os.path.join("..", "automation-tools")))

    try:
        import unity_package_build
        print "package_build.setup()"
        build_log = unity_package_build.setup()
    except ImportError:
        print "No Automation Tools found."
