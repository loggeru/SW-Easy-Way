﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SW_Easy_Way.Config
{

	public class Wb
	{
		public Wb()
		{
			Enabled = false;
			Repeat = 3;
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("repeat")]
		public int Repeat { get; set; }
	}

	public class FriendGift
	{
		public FriendGift()
		{
			Enabled = false;
			Toall = true;
			Friends = 0;
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("toall")]
		public bool Toall { get; set; }

		[JsonProperty("friends")]
		public int Friends { get; set; }
	}

	public class RivalArena
	{
		public RivalArena()
		{
			Enabled = false;
			Continuous = true;
			Deck = 1;
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("continuous")]
		public bool Continuous { get; set; }

		[JsonProperty("deck")]
		public int Deck { get; set; }
	}

	public class Giant
	{
		public Giant()
		{
			Enabled = false;
			Floor = 10;
			Pattern = RoutinePattern.RunOnce;
			Repeat = 0;
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("floor")]
		public int Floor { get; set; }

		[JsonProperty("pattern")]
		[JsonConverter(typeof(PatternTypeConverter))]
		public RoutinePattern Pattern { get; set; }

		[JsonProperty("repeat")]
		public int Repeat { get; set; }
	}

	public class Dragon
	{
		public Dragon()
		{
			Enabled = false;
			Floor = 10;
			Pattern = RoutinePattern.RunOnce;
			Repeat = 0;
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("floor")]
		public int Floor { get; set; }

		[JsonProperty("pattern")]
		[JsonConverter(typeof(PatternTypeConverter))]
		public RoutinePattern Pattern { get; set; }

		[JsonProperty("repeat")]
		public int Repeat { get; set; }
	}

	public class Necro
	{
		public Necro()
		{
			Enabled = false;
			Floor = 10;
			Pattern = RoutinePattern.RunOnce;
			Repeat = 0;
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("floor")]
		public int Floor { get; set; }

		[JsonProperty("pattern")]
		[JsonConverter(typeof(PatternTypeConverter))]
		public RoutinePattern Pattern { get; set; }

		[JsonProperty("repeat")]
		public int Repeat { get; set; }
	}

	public class ElementalHall
	{
		public ElementalHall()
		{
			Enabled = false;
			Element = ElementalType.Fire;
			Floor = 10;
			Pattern = RoutinePattern.RunOnce;
			Repeat = 0;
			Essences = new[] { 0, 0, 0 };
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("element")]
		[JsonConverter(typeof(ElementalTypeConverter))]
		public ElementalType Element { get; set; }

		[JsonProperty("floor")]
		public int Floor { get; set; }

		[JsonProperty("repeat")]
		public int Repeat { get; set; }

		[JsonProperty("pattern")]
		[JsonConverter(typeof(PatternTypeConverter))]
		public RoutinePattern Pattern { get; set; }

		[JsonProperty("essences")]
		public int[] Essences { get; set; }
	}

	public class MagicHall
	{
		public MagicHall()
		{
			Enabled = false;
			Floor = 10;
			Pattern = RoutinePattern.RunOnce;
			Repeat = 0;
			Essences = new[] { 0, 0, 0 };
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("floor")]
		public int Floor { get; set; }

		[JsonProperty("repeat")]
		public int Repeat { get; set; }

		[JsonProperty("pattern")]
		[JsonConverter(typeof(PatternTypeConverter))]
		public RoutinePattern Pattern { get; set; }

		[JsonProperty("essences")]
		public int[] Essences { get; set; }
	}

	public class Runepattern
	{
		[JsonProperty("main")]
		[JsonConverter(typeof(RuneStatTypeConverter))]
		public RuneStat Main { get; set; }

		[JsonProperty("sub1")]
		[JsonConverter(typeof(RuneStatTypeConverter))]
		public RuneStat Sub1 { get; set; }

		[JsonProperty("sub2")]
		[JsonConverter(typeof(RuneStatTypeConverter))]
		public RuneStat Sub2 { get; set; }

		[JsonProperty("sub3")]
		[JsonConverter(typeof(RuneStatTypeConverter))]
		public RuneStat Sub3 { get; set; }
	}

	public class Smartrune
	{
		public Smartrune()
		{
			Enabled = false;
			Min246 = 6;
			Min2Spd = 5;
			Minstars = 5;
			Minrarity5 = RuneRarity.Rare;
			Minrarity6 = RuneRarity.Rare;
			Runepattern = new Runepattern[0];
		}

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("min246")]
		public int Min246 { get; set; }

		[JsonProperty("min2spd")]
		public int Min2Spd { get; set; }

		[JsonProperty("minstars")]
		public int Minstars { get; set; }

		[JsonProperty("minrarity5")]
		[JsonConverter(typeof(RuneRarityConverter))]
		public RuneRarity Minrarity5 { get; set; }

		[JsonProperty("minrarity6")]
		[JsonConverter(typeof(RuneRarityConverter))]
		public RuneRarity Minrarity6 { get; set; }

		[JsonProperty("runepattern")]
		public Runepattern[] Runepattern { get; set; }
	}

	public class JsonConfig
	{
		public JsonConfig()
		{
			WizardId = "";
			Wb = new Wb();
			FriendGift = new FriendGift();
			RivalArena = new RivalArena();
			Giant = new Giant();
			Dragon = new Dragon();
			Necro = new Necro();
			ElementalHall = new ElementalHall();
			MagicHall = new MagicHall();
			Smartrune = new Smartrune();
		}

		[JsonProperty("serial")]
		public string Serial { get; set; }

		[JsonProperty("wi_name")]
		public string WizardName { get; set; }

		[JsonProperty("wi_id")]
		public string WizardId { get; set; }

		[JsonProperty("wb")]
		public Wb Wb { get; set; }

		[JsonProperty("friend_gift")]
		public FriendGift FriendGift { get; set; }

		[JsonProperty("rival_arena")]
		public RivalArena RivalArena { get; set; }

		[JsonProperty("giant")]
		public Giant Giant { get; set; }

		[JsonProperty("dragon")]
		public Dragon Dragon { get; set; }

		[JsonProperty("necro")]
		public Necro Necro { get; set; }

		[JsonProperty("elemental_hall")]
		public ElementalHall ElementalHall { get; set; }

		[JsonProperty("magic_hall")]
		public MagicHall MagicHall { get; set; }

		[JsonProperty("smartrune")]
		public Smartrune Smartrune { get; set; }
	}

	public class Profiles
	{
		[JsonProperty("json_config")]
		public JsonConfig[] JsonConfig { get; set; }
	}

	public enum RoutinePattern
	{
		RunOnce,
		RefreshAndRepeat,
		UntilZeroEnergy
	}

	public enum ElementalType
	{
		Magic,
		Light,
		Dark,
		Fire,
		Water,
		Wind
	}

	public class RuneRarityConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			value = (RuneRarity)value;

			switch (value)
			{
				case RuneRarity.Normal:
					writer.WriteValue("normal");
					break;
				case RuneRarity.Magic:
					writer.WriteValue("magic");
					break;
				case RuneRarity.Hero:
					writer.WriteValue("hero");
					break;
				case RuneRarity.Rare:
					writer.WriteValue("rare");
					break;
				case RuneRarity.Legend:
					writer.WriteValue("legend");
					break;
				default:
					writer.WriteValue("normal");
					break;
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var value = (string)reader.Value;
			switch (value)
			{
				case "normal":
					return RuneRarity.Normal;
				case "magic":
					return RuneRarity.Magic;
				case "hero":
					return RuneRarity.Hero;
				case "rare":
					return RuneRarity.Rare;
				case "legend":
					return RuneRarity.Legend;
				default:
					return RuneRarity.Normal;
			}
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(string);
		}
	}

	public class RuneStatTypeConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			value = (RuneStat)value;
			switch (value)
			{
				case RuneStat.None:
					writer.WriteValue("");
					break;
				case RuneStat.Spd:
					writer.WriteValue("spd");
					break;
				case RuneStat.HpFlat:
					writer.WriteValue("hpf");
					break;
				case RuneStat.Hp:
					writer.WriteValue("hp");
					break;
				case RuneStat.DefFlat:
					writer.WriteValue("deff");
					break;
				case RuneStat.Def:
					writer.WriteValue("def");
					break;
				case RuneStat.Accuracy:
					writer.WriteValue("acc");
					break;
				case RuneStat.CritRate:
					writer.WriteValue("critr");
					break;
				case RuneStat.CritDmg:
					writer.WriteValue("critd");
					break;
				case RuneStat.Atk:
					writer.WriteValue("atk");
					break;
				case RuneStat.AtkFlat:
					writer.WriteValue("atkf");
					break;
				default:
					writer.WriteValue("");
					break;
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var value = (string)reader.Value;
			switch (value)
			{
				case "spd":
					return RuneStat.Spd;
				case "hpf":
					return RuneStat.HpFlat;
				case "hp":
					return RuneStat.Hp;
				case "deff":
					return RuneStat.DefFlat;
				case "def":
					return RuneStat.Def;
				case "acc":
					return RuneStat.Accuracy;
				case "critr":
					return RuneStat.CritRate;
				case "critd":
					return RuneStat.CritDmg;
				case "atkf":
					return RuneStat.AtkFlat;
				case "atk":
					return RuneStat.Atk;
				default:
					return RuneStat.None;
			}
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(string);
		}
	}

	public class PatternTypeConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			value = (RoutinePattern)value;

			switch (value)
			{
				case RoutinePattern.RunOnce:
					writer.WriteValue("run_once");
					break;
				case RoutinePattern.RefreshAndRepeat:
					writer.WriteValue("refresh_repeat");
					break;
				case RoutinePattern.UntilZeroEnergy:
					writer.WriteValue("zero_energy");
					break;
				default:
					writer.WriteValue("run_once");
					break;
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var value = (string)reader.Value;
			switch (value)
			{
				case "run_once":
					return RoutinePattern.RunOnce;
				case "refresh_repeat":
					return RoutinePattern.RefreshAndRepeat;
				case "zero_energy":
					return RoutinePattern.UntilZeroEnergy;
				default:
					return RoutinePattern.RunOnce;
			}
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(string);
		}
	}

	public class ElementalTypeConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			value = (ElementalType)value;

			switch (value)
			{
				case ElementalType.Light:
					writer.WriteValue("light");
					break;
				case ElementalType.Dark:
					writer.WriteValue("dark");
					break;
				case ElementalType.Fire:
					writer.WriteValue("fire");
					break;
				case ElementalType.Water:
					writer.WriteValue("water");
					break;
				case ElementalType.Wind:
					writer.WriteValue("wind");
					break;
				default:
					writer.WriteValue("light");
					break;
			}
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var value = (string)reader.Value;
			switch (value)
			{
				case "light":
					return ElementalType.Light;
				case "dark":
					return ElementalType.Dark;
				case "fire":
					return ElementalType.Fire;
				case "water":
					return ElementalType.Water;
				case "wind":
					return ElementalType.Wind;
				default:
					return ElementalType.Light;
			}
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(string);
		}
	}
}