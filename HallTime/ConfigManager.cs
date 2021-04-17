using System;
using Json.Net;

namespace HallTime
{

	public class ConfigManager
    {
		private enum ConfigType 
		{
			MEASURES_CONFIG,
			DEFAULT_NAMES_CONFIG,
			TUTORIAL_CONFIG,
			INITIAL_CONFIG
		};

    	private Dictionary<ConfigType, Json> configurations;

    	ConfigManager(string measuresConfigPath, string defaultNamesConfigPath, string tutorialConfigPath, string initialConfigPath)
    	{
    		configurations.insert(ConfigType.MEASURES_CONFIG, load(measuresConfigPath));
    		configurations.insert(ConfigType.DEFAULT_NAMES_CONFIG, load(defaultNamesConfigPath));
    		configurations.insert(ConfigType.TUTORIAL_CONFIG, load(tutorialConfigPath));
    		configurations.insert(ConfigType.INITIAL_CONFIG, load(initialConfigPath));
    	}

    	public Json getMeasuresConfig() 
    	{
    		configurations.get(MEASURES_CONFIG);
    	}

    	public Json getDefaultNamesConfig()
    	{
    		configurations.get(DEFAULT_NAMES_CONFIG);
    	}

    	public Json getTutorialConfig()
    	{
    		configurations.get(TUTORIAL_CONFIG);
    	}

    	public Json getInitialConfig()
    	{
    		configurations.get(INITIAL_CONFIG);
    	}

    	private Json load(string path)
	    {    	
	    	// перевести в string, либо использовать путь напрямую
	    	JObject object; = new JObject(data); // data - которую мы считили
	    	return object;
    	}

    }

}