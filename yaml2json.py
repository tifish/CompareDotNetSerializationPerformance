# convert yaml to json
# pip3 install pyyaml
# http://pyyaml.org/wiki/PyYAMLDocumentation
# py3 yaml2json.py < ~/code/manpow/homeland/heartland/puphpet/config.yaml
# gist https://gist.github.com/noahcoad/51934724e0896184a2340217b383af73

import yaml, json, sys

with open(sys.argv[1], mode='r') as inFile:
    json = json.dumps(yaml.load(inFile), indent=2)
    with open(sys.argv[2], mode='w') as outFile:
        outFile.write(json)
