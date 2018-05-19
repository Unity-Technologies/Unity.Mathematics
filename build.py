#!/usr/bin/python -B
import os
import platform
import logging

def packages_list():
    return [
        ("com.unity.mathematics", os.path.join("src"))
    ]

if __name__ == "__main__":
    import sys
    sys.path.insert(0, os.path.abspath(os.path.join("..", "automation-tools")))
    
    try:
        import unity_package_build
        build_log = unity_package_build.setup()
    except ImportError:
        print "No Automation Tools found."
