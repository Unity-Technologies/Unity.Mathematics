#!/usr/bin/python -B
import os
import platform
import logging

def packages_list():
    return [
        ("com.unity.mathematics", os.path.join("src"))
    ]

# Prepare an empty project for editor tests
def prepare_editor_test_project(repo_path, project_path, logger):
    import unity_package_build
    settings_to_swap = {
        "scriptingRuntimeVersion: 0": "scriptingRuntimeVersion: 1",
        "apiCompatibilityLevel: 2": "apiCompatibilityLevel: 3"
    }
    projectsettings_path = os.path.join(project_path, "ProjectSettings", "ProjectSettings.asset")
    settings = ""
    with open(projectsettings_path) as f:
        settings = f.read()
        for key, value in settings_to_swap.iteritems():
            settings = settings.replace(key, value)

    with open(projectsettings_path, 'w') as f:
        f.write(settings)

if __name__ == "__main__":
    import sys
    sys.path.insert(0, os.path.abspath(os.path.join("..", "automation-tools")))
    
    try:
        import unity_package_build
        build_log = unity_package_build.setup()
    except ImportError:
        print "No Automation Tools found."
