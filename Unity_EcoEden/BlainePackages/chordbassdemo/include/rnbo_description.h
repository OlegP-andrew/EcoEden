#pragma once

#ifdef RNBO_DESCRIPTION_AS_STRING

namespace RNBO {
	const std::string patcher_description(
			R"RNBOLIT({
  "parameters": [
    {
      "type": "ParameterTypeNumber",
      "index": 0,
      "name": "bassvol",
      "paramId": "bassvol",
      "minimum": 0,
      "maximum": 120,
      "exponent": 1,
      "steps": 0,
      "initialValue": 110,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNum)RNBOLIT"
R"RNBOLIT(ber",
      "index": 1,
      "name": "chord1spawnrate",
      "paramId": "chord1spawnrate",
      "minimum": 7,
      "maximum": 63,
      "exponent": 1,
      "steps": 0,
      "initialValue": 31,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 2,
      "name": "chor)RNBOLIT"
R"RNBOLIT(d1oct",
      "paramId": "chord1oct",
      "minimum": 0,
      "maximum": 6,
      "exponent": 1,
      "steps": 0,
      "initialValue": 4,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 3,
      "name": "chord1voicevol",
      "paramId": "chord1voicevol",
      "mi)RNBOLIT"
R"RNBOLIT(nimum": 0,
      "maximum": 120,
      "exponent": 1,
      "steps": 0,
      "initialValue": 100,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 4,
      "name": "chord1att",
      "paramId": "chord1att",
      "minimum": 0,
      "maximum": 12000,
      "exponent": )RNBOLIT"
R"RNBOLIT(1,
      "steps": 0,
      "initialValue": 12000,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 5,
      "name": "chord1dec",
      "paramId": "chord1dec",
      "minimum": 0,
      "maximum": 30000,
      "exponent": 1,
      "steps": 0,
      "initialValue": 24000,)RNBOLIT"
R"RNBOLIT(
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 6,
      "name": "verbsize",
      "paramId": "verbsize",
      "minimum": 0.01,
      "maximum": 1.6,
      "exponent": 1,
      "steps": 0,
      "initialValue": 1,
      "isEnum": false,
      "enumValues": [],
      )RNBOLIT"
R"RNBOLIT("displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 7,
      "name": "verbdecaytime",
      "paramId": "verbdecaytime",
      "minimum": 0.05,
      "maximum": 0.9,
      "exponent": 1,
      "steps": 0,
      "initialValue": 0.7,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
     )RNBOLIT"
R"RNBOLIT( "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 8,
      "name": "verbhfdamp",
      "paramId": "verbhfdamp",
      "minimum": 20,
      "maximum": 12000,
      "exponent": 1,
      "steps": 0,
      "initialValue": 8000,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visib)RNBOLIT"
R"RNBOLIT(le": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 9,
      "name": "chord1sus",
      "paramId": "chord1sus",
      "minimum": 0,
      "maximum": 1,
      "exponent": 1,
      "steps": 0,
      "initialValue": 0,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IO)RNBOLIT"
R"RNBOLIT(TypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 10,
      "name": "verbdiffusion",
      "paramId": "verbdiffusion",
      "minimum": 0,
      "maximum": 1,
      "exponent": 1,
      "steps": 0,
      "initialValue": 0.7,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "Par)RNBOLIT"
R"RNBOLIT(ameterTypeNumber",
      "index": 11,
      "name": "chord1rel",
      "paramId": "chord1rel",
      "minimum": 30,
      "maximum": 10000,
      "exponent": 1,
      "steps": 0,
      "initialValue": 3000,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    }
  ],
  "numParameters": 12,
  "numSignalInParameters": 0,
  "numSignalOut)RNBOLIT"
R"RNBOLIT(Parameters": 0,
  "numInputChannels": 0,
  "numOutputChannels": 2,
  "numMidiInputPorts": 0,
  "numMidiOutputPorts": 0,
  "externalDataRefs": [],
  "patcherSerial": 0,
  "inports": [],
  "outports": [],
  "inlets": [],
  "outlets": [
    {
      "type": "signal",
      "index": 1,
      "tag": "out1",
      "meta": ""
    },
    {
      "type": "signal",
      "index": 2,
      "tag": "out2",
      "meta": ""
    }
  ],
  "presetid": "rnbo",
  "meta": {
    "architecture": "x64",
    "filename":)RNBOLIT"
R"RNBOLIT( "EcoEdenRNBOGenerativeOG.maxpat",
    "rnboobjname": "rnbomatic",
    "maxversion": "8.6.1",
    "rnboversion": "1.2.4",
    "name": "untitled"
  }
})RNBOLIT"
		);

	const std::string patcher_presets(
			R"RNBOLIT([
  {
    "name": "untitled",
    "preset": {
      "__sps": {
        "bass": {},
        "chord1": [
          {},
          {},
          {},
          {},
          {}
        ],
        "chord1markov": {},
        "reverb": {
          "__sps": {
            "combineL": {},
            "combineR": {}
          }
        }
      },
      "bassvol": {
        "value": 110
      },
      "chord1att": {
        "value": 12000
      },
      "chord1dec": {
        "value": 24000
      },
      ")RNBOLIT"
R"RNBOLIT(chord1oct": {
        "value": 4
      },
      "chord1rel": {
        "value": 3000
      },
      "chord1spawnrate": {
        "value": 31
      },
      "chord1sus": {
        "value": 0
      },
      "chord1voicevol": {
        "value": 100
      },
      "verbdecaytime": {
        "value": 0.7
      },
      "verbdiffusion": {
        "value": 0.7
      },
      "verbhfdamp": {
        "value": 8000
      },
      "verbsize": {
        "value": 1
      }
    }
  }
])RNBOLIT"
		);
}

#else

#include <json/json.hpp>

namespace RNBO {
	const nlohmann::json patcher_description = nlohmann::json::parse(
			std::string(
				R"RNBOLIT({
  "parameters": [
    {
      "type": "ParameterTypeNumber",
      "index": 0,
      "name": "bassvol",
      "paramId": "bassvol",
      "minimum": 0,
      "maximum": 120,
      "exponent": 1,
      "steps": 0,
      "initialValue": 110,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNum)RNBOLIT"
R"RNBOLIT(ber",
      "index": 1,
      "name": "chord1spawnrate",
      "paramId": "chord1spawnrate",
      "minimum": 7,
      "maximum": 63,
      "exponent": 1,
      "steps": 0,
      "initialValue": 31,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 2,
      "name": "chor)RNBOLIT"
R"RNBOLIT(d1oct",
      "paramId": "chord1oct",
      "minimum": 0,
      "maximum": 6,
      "exponent": 1,
      "steps": 0,
      "initialValue": 4,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 3,
      "name": "chord1voicevol",
      "paramId": "chord1voicevol",
      "mi)RNBOLIT"
R"RNBOLIT(nimum": 0,
      "maximum": 120,
      "exponent": 1,
      "steps": 0,
      "initialValue": 100,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 4,
      "name": "chord1att",
      "paramId": "chord1att",
      "minimum": 0,
      "maximum": 12000,
      "exponent": )RNBOLIT"
R"RNBOLIT(1,
      "steps": 0,
      "initialValue": 12000,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 5,
      "name": "chord1dec",
      "paramId": "chord1dec",
      "minimum": 0,
      "maximum": 30000,
      "exponent": 1,
      "steps": 0,
      "initialValue": 24000,)RNBOLIT"
R"RNBOLIT(
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 6,
      "name": "verbsize",
      "paramId": "verbsize",
      "minimum": 0.01,
      "maximum": 1.6,
      "exponent": 1,
      "steps": 0,
      "initialValue": 1,
      "isEnum": false,
      "enumValues": [],
      )RNBOLIT"
R"RNBOLIT("displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 7,
      "name": "verbdecaytime",
      "paramId": "verbdecaytime",
      "minimum": 0.05,
      "maximum": 0.9,
      "exponent": 1,
      "steps": 0,
      "initialValue": 0.7,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
     )RNBOLIT"
R"RNBOLIT( "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 8,
      "name": "verbhfdamp",
      "paramId": "verbhfdamp",
      "minimum": 20,
      "maximum": 12000,
      "exponent": 1,
      "steps": 0,
      "initialValue": 8000,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visib)RNBOLIT"
R"RNBOLIT(le": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 9,
      "name": "chord1sus",
      "paramId": "chord1sus",
      "minimum": 0,
      "maximum": 1,
      "exponent": 1,
      "steps": 0,
      "initialValue": 0,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IO)RNBOLIT"
R"RNBOLIT(TypeUndefined"
    },
    {
      "type": "ParameterTypeNumber",
      "index": 10,
      "name": "verbdiffusion",
      "paramId": "verbdiffusion",
      "minimum": 0,
      "maximum": 1,
      "exponent": 1,
      "steps": 0,
      "initialValue": 0.7,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    },
    {
      "type": "Par)RNBOLIT"
R"RNBOLIT(ameterTypeNumber",
      "index": 11,
      "name": "chord1rel",
      "paramId": "chord1rel",
      "minimum": 30,
      "maximum": 10000,
      "exponent": 1,
      "steps": 0,
      "initialValue": 3000,
      "isEnum": false,
      "enumValues": [],
      "displayName": "",
      "unit": "",
      "order": 0,
      "debug": false,
      "visible": true,
      "signalIndex": null,
      "ioType": "IOTypeUndefined"
    }
  ],
  "numParameters": 12,
  "numSignalInParameters": 0,
  "numSignalOut)RNBOLIT"
R"RNBOLIT(Parameters": 0,
  "numInputChannels": 0,
  "numOutputChannels": 2,
  "numMidiInputPorts": 0,
  "numMidiOutputPorts": 0,
  "externalDataRefs": [],
  "patcherSerial": 0,
  "inports": [],
  "outports": [],
  "inlets": [],
  "outlets": [
    {
      "type": "signal",
      "index": 1,
      "tag": "out1",
      "meta": ""
    },
    {
      "type": "signal",
      "index": 2,
      "tag": "out2",
      "meta": ""
    }
  ],
  "presetid": "rnbo",
  "meta": {
    "architecture": "x64",
    "filename":)RNBOLIT"
R"RNBOLIT( "EcoEdenRNBOGenerativeOG.maxpat",
    "rnboobjname": "rnbomatic",
    "maxversion": "8.6.1",
    "rnboversion": "1.2.4",
    "name": "untitled"
  }
})RNBOLIT"
			)
		);

	const nlohmann::json patcher_presets = nlohmann::json::parse(
			std::string(
				R"RNBOLIT([
  {
    "name": "untitled",
    "preset": {
      "__sps": {
        "bass": {},
        "chord1": [
          {},
          {},
          {},
          {},
          {}
        ],
        "chord1markov": {},
        "reverb": {
          "__sps": {
            "combineL": {},
            "combineR": {}
          }
        }
      },
      "bassvol": {
        "value": 110
      },
      "chord1att": {
        "value": 12000
      },
      "chord1dec": {
        "value": 24000
      },
      ")RNBOLIT"
R"RNBOLIT(chord1oct": {
        "value": 4
      },
      "chord1rel": {
        "value": 3000
      },
      "chord1spawnrate": {
        "value": 31
      },
      "chord1sus": {
        "value": 0
      },
      "chord1voicevol": {
        "value": 100
      },
      "verbdecaytime": {
        "value": 0.7
      },
      "verbdiffusion": {
        "value": 0.7
      },
      "verbhfdamp": {
        "value": 8000
      },
      "verbsize": {
        "value": 1
      }
    }
  }
])RNBOLIT"
			)
		);
}

#endif
