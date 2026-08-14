using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace UMACharacterSystem;

[Token(Token = "0x2003C4B")]
public class DynamicCharacterAvatar : UmaAvatarWithSlots<UMATextRecipe>, _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x2003C4C")]
	public enum LoadOptions
	{
		[Token(Token = "0x4019A6E")]
		useDefaults = 0,
		[Token(Token = "0x4019A6F")]
		loadRace = 1,
		[Token(Token = "0x4019A70")]
		loadWardrobe = 4,
		[Token(Token = "0x4019A71")]
		loadBodyColors = 8,
		[Token(Token = "0x4019A72")]
		loadWardrobeColors = 0x10
	}

	[Token(Token = "0x2003C4D")]
	public enum SaveOptions
	{
		[Token(Token = "0x4019A74")]
		useDefaults = 0,
		[Token(Token = "0x4019A75")]
		saveWardrobe = 2,
		[Token(Token = "0x4019A76")]
		saveColors = 4,
		[Token(Token = "0x4019A77")]
		saveAnimator = 8
	}

	[Token(Token = "0x2003C4E")]
	public enum loadPathTypes
	{
		[Token(Token = "0x4019A79")]
		persistentDataPath,
		[Token(Token = "0x4019A7A")]
		Resources,
		[Token(Token = "0x4019A7B")]
		FileSystem,
		[Token(Token = "0x4019A7C")]
		CharacterSystem,
		[Token(Token = "0x4019A7D")]
		String
	}

	[Token(Token = "0x2003C4F")]
	public enum savePathTypes
	{
		[Token(Token = "0x4019A7F")]
		persistentDataPath,
		[Token(Token = "0x4019A80")]
		Resources,
		[Token(Token = "0x4019A81")]
		FileSystem
	}

	[Serializable]
	[Token(Token = "0x2003C50")]
	public class RaceSetter
	{
		[Token(Token = "0x4019A82")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4019A83")]
		[FieldOffset(Offset = "0xC")]
		private RaceData _data;

		[Token(Token = "0x4019A84")]
		[FieldOffset(Offset = "0x10")]
		private RaceData[] _cachedRaceDatas;

		[Token(Token = "0x17001982")]
		public RaceData data
		{
			[Token(Token = "0x601812F")]
			[Address(RVA = "0x35F64BC", Offset = "0x35F64BC", VA = "0x35F64BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6018130")]
			[Address(RVA = "0x35F64B4", Offset = "0x35F64B4", VA = "0x35F64B4")]
			set
			{
			}
		}

		[Token(Token = "0x17001983")]
		public RaceData racedata
		{
			[Token(Token = "0x6018131")]
			[Address(RVA = "0x35F3940", Offset = "0x35F3940", VA = "0x35F3940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601812E")]
		[Address(RVA = "0x35F31D8", Offset = "0x35F31D8", VA = "0x35F31D8")]
		public RaceSetter()
		{
		}

		[Token(Token = "0x6018132")]
		[Address(RVA = "0x35FCBEC", Offset = "0x35FCBEC", VA = "0x35FCBEC")]
		private RaceData Validate()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003C51")]
	public class WardrobeRecipeListItem
	{
		[Token(Token = "0x4019A85")]
		[FieldOffset(Offset = "0x8")]
		public string _recipeName;

		[Token(Token = "0x4019A86")]
		[FieldOffset(Offset = "0xC")]
		public UMATextRecipe _recipe;

		[Token(Token = "0x4019A87")]
		[FieldOffset(Offset = "0x10")]
		public List<string> _compatibleRaces;

		[Token(Token = "0x6018133")]
		[Address(RVA = "0x35FD494", Offset = "0x35FD494", VA = "0x35FD494")]
		public WardrobeRecipeListItem()
		{
		}

		[Token(Token = "0x6018134")]
		[Address(RVA = "0x35FD49C", Offset = "0x35FD49C", VA = "0x35FD49C")]
		public WardrobeRecipeListItem(string recipeName)
		{
		}

		[Token(Token = "0x6018135")]
		[Address(RVA = "0x35FD4BC", Offset = "0x35FD4BC", VA = "0x35FD4BC")]
		public WardrobeRecipeListItem(UMATextRecipe recipe)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C52")]
	public class WardrobeRecipeList
	{
		[Token(Token = "0x4019A88")]
		[FieldOffset(Offset = "0x8")]
		public bool loadDefaultRecipes;

		[Token(Token = "0x4019A89")]
		[FieldOffset(Offset = "0xC")]
		public List<WardrobeRecipeListItem> recipes;

		[Token(Token = "0x6018136")]
		[Address(RVA = "0x35FCDD4", Offset = "0x35FCDD4", VA = "0x35FCDD4")]
		public WardrobeRecipeList()
		{
		}

		[Token(Token = "0x6018137")]
		[Address(RVA = "0x35FCE68", Offset = "0x35FCE68", VA = "0x35FCE68")]
		public List<WardrobeRecipeListItem> Validate(bool allowDownloadables = false, string raceName = "")
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003C53")]
	public class ColorValue : OverlayColorData
	{
		[Token(Token = "0x4019A8A")]
		[FieldOffset(Offset = "0x14")]
		private string _name;

		[Token(Token = "0x4019A8B")]
		[FieldOffset(Offset = "0x18")]
		private Color _color;

		[Token(Token = "0x4019A8C")]
		[FieldOffset(Offset = "0x28")]
		private Color _metallicGloss;

		[Token(Token = "0x4019A8D")]
		[FieldOffset(Offset = "0x38")]
		public bool valuesConverted;

		[Token(Token = "0x17001984")]
		public string Name
		{
			[Token(Token = "0x601813E")]
			[Address(RVA = "0x35FC1E8", Offset = "0x35FC1E8", VA = "0x35FC1E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x601813F")]
			[Address(RVA = "0x35FC32C", Offset = "0x35FC32C", VA = "0x35FC32C")]
			set
			{
			}
		}

		[Token(Token = "0x17001985")]
		public Color Color
		{
			[Token(Token = "0x6018140")]
			[Address(RVA = "0x35FC334", Offset = "0x35FC334", VA = "0x35FC334")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Color);
			}
			[Token(Token = "0x6018141")]
			[Address(RVA = "0x35FC368", Offset = "0x35FC368", VA = "0x35FC368")]
			set
			{
			}
		}

		[Token(Token = "0x17001986")]
		public Color MetallicGloss
		{
			[Token(Token = "0x6018142")]
			[Address(RVA = "0x35FC38C", Offset = "0x35FC38C", VA = "0x35FC38C")]
			get
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return default(Color);
			}
			[Token(Token = "0x6018143")]
			[Address(RVA = "0x35FC3EC", Offset = "0x35FC3EC", VA = "0x35FC3EC")]
			set
			{
			}
		}

		[Token(Token = "0x6018138")]
		[Address(RVA = "0x35FBC18", Offset = "0x35FBC18", VA = "0x35FBC18")]
		public ColorValue()
		{
		}

		[Token(Token = "0x6018139")]
		[Address(RVA = "0x35FBDC8", Offset = "0x35FBDC8", VA = "0x35FBDC8")]
		public ColorValue(int channels)
		{
		}

		[Token(Token = "0x601813A")]
		[Address(RVA = "0x35FBE4C", Offset = "0x35FBE4C", VA = "0x35FBE4C")]
		public ColorValue(string nameVal, Color colorVal)
		{
		}

		[Token(Token = "0x601813B")]
		[Address(RVA = "0x35FC030", Offset = "0x35FC030", VA = "0x35FC030")]
		public ColorValue(string nameVal, OverlayColorData color)
		{
		}

		[Token(Token = "0x601813C")]
		[Address(RVA = "0x35FC0C8", Offset = "0x35FC0C8", VA = "0x35FC0C8")]
		public ColorValue(ColorValue col)
		{
		}

		[Token(Token = "0x601813D")]
		[Address(RVA = "0x35FC158", Offset = "0x35FC158", VA = "0x35FC158")]
		public ColorValue(OverlayColorData col)
		{
		}

		[Token(Token = "0x6018144")]
		[Address(RVA = "0x35FC20C", Offset = "0x35FC20C", VA = "0x35FC20C")]
		private void ConvertOldFieldsToNew()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C54")]
	public class ColorValueList
	{
		[Token(Token = "0x4019A8E")]
		[FieldOffset(Offset = "0x8")]
		public List<ColorValue> _colors;

		[Token(Token = "0x17001987")]
		public List<ColorValue> Colors
		{
			[Token(Token = "0x6018148")]
			[Address(RVA = "0x35F396C", Offset = "0x35F396C", VA = "0x35F396C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6018149")]
			[Address(RVA = "0x35FC608", Offset = "0x35FC608", VA = "0x35FC608")]
			set
			{
			}
		}

		[Token(Token = "0x6018145")]
		[Address(RVA = "0x35F31E0", Offset = "0x35F31E0", VA = "0x35F31E0")]
		public ColorValueList()
		{
		}

		[Token(Token = "0x6018146")]
		[Address(RVA = "0x35FC47C", Offset = "0x35FC47C", VA = "0x35FC47C")]
		public ColorValueList(OverlayColorData[] colors)
		{
		}

		[Token(Token = "0x6018147")]
		[Address(RVA = "0x35FC574", Offset = "0x35FC574", VA = "0x35FC574")]
		public ColorValueList(List<ColorValue> colorValueList)
		{
		}

		[Token(Token = "0x601814A")]
		[Address(RVA = "0x35FC610", Offset = "0x35FC610", VA = "0x35FC610")]
		private ColorValue GetColorValue(string name)
		{
			return null;
		}

		[Token(Token = "0x601814B")]
		[Address(RVA = "0x35FC7D0", Offset = "0x35FC7D0", VA = "0x35FC7D0")]
		public OverlayColorData[] ToOverlayColors()
		{
			return null;
		}

		[Token(Token = "0x601814C")]
		[Address(RVA = "0x35FC848", Offset = "0x35FC848", VA = "0x35FC848")]
		public OverlayColorData ToOverlayColorData(ColorValue cv)
		{
			return null;
		}

		[Token(Token = "0x601814D")]
		[Address(RVA = "0x35FC850", Offset = "0x35FC850", VA = "0x35FC850")]
		public bool GetColor(string Name, out Color c)
		{
			return default(bool);
		}

		[Token(Token = "0x601814E")]
		[Address(RVA = "0x35F84A4", Offset = "0x35F84A4", VA = "0x35F84A4")]
		public bool GetColor(string Name, out OverlayColorData c)
		{
			return default(bool);
		}

		[Token(Token = "0x601814F")]
		[Address(RVA = "0x35FC8D0", Offset = "0x35FC8D0", VA = "0x35FC8D0")]
		public void SetColor(string name, Color c)
		{
		}

		[Token(Token = "0x6018150")]
		[Address(RVA = "0x35F8720", Offset = "0x35F8720", VA = "0x35F8720")]
		public void SetColor(string name, OverlayColorData c)
		{
		}

		[Token(Token = "0x6018151")]
		[Address(RVA = "0x35FC9F4", Offset = "0x35FC9F4", VA = "0x35FC9F4")]
		public void RemoveColor(string name)
		{
		}
	}

	[Token(Token = "0x2003C55")]
	private sealed class _003CBuildFromComponentSettingsCO_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019A8F")]
		[FieldOffset(Offset = "0x8")]
		internal DynamicCharacterAvatar _0024this;

		[Token(Token = "0x4019A90")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019A91")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4019A92")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001988")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6018154")]
			[Address(RVA = "0x35FB3E0", Offset = "0x35FB3E0", VA = "0x35FB3E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001989")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6018155")]
			[Address(RVA = "0x35FB3E8", Offset = "0x35FB3E8", VA = "0x35FB3E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6018152")]
		[Address(RVA = "0x35F64AC", Offset = "0x35F64AC", VA = "0x35F64AC")]
		public _003CBuildFromComponentSettingsCO_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6018153")]
		[Address(RVA = "0x35FB28C", Offset = "0x35FB28C", VA = "0x35FB28C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6018156")]
		[Address(RVA = "0x35FB3F0", Offset = "0x35FB3F0", VA = "0x35FB3F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6018157")]
		[Address(RVA = "0x35FB404", Offset = "0x35FB404", VA = "0x35FB404", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003C56")]
	private sealed class _003CImportSettingsCO_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019A93")]
		[FieldOffset(Offset = "0x8")]
		internal LoadOptions customLoadOptions;

		[Token(Token = "0x4019A94")]
		[FieldOffset(Offset = "0xC")]
		internal LoadOptions _003CthisLoadOptions_003E__0;

		[Token(Token = "0x4019A95")]
		[FieldOffset(Offset = "0x10")]
		internal bool forceDCSLoad;

		[Token(Token = "0x4019A96")]
		[FieldOffset(Offset = "0x14")]
		internal UMATextRecipe.DCSUniversalPackRecipe settingsToLoad;

		[Token(Token = "0x4019A97")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003CwasBuildCharacterEnabled_003E__0;

		[Token(Token = "0x4019A98")]
		[FieldOffset(Offset = "0x19")]
		internal bool _003CneedsUpdate_003E__0;

		[Token(Token = "0x4019A99")]
		[FieldOffset(Offset = "0x1C")]
		internal DynamicCharacterAvatar _0024this;

		[Token(Token = "0x4019A9A")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4019A9B")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4019A9C")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x1700198A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601815A")]
			[Address(RVA = "0x35FBB6C", Offset = "0x35FBB6C", VA = "0x35FBB6C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700198B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601815B")]
			[Address(RVA = "0x35FBB74", Offset = "0x35FBB74", VA = "0x35FBB74", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6018158")]
		[Address(RVA = "0x35F9A5C", Offset = "0x35F9A5C", VA = "0x35F9A5C")]
		public _003CImportSettingsCO_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6018159")]
		[Address(RVA = "0x35FB48C", Offset = "0x35FB48C", VA = "0x35FB48C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601815C")]
		[Address(RVA = "0x35FBB7C", Offset = "0x35FBB7C", VA = "0x35FBB7C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601815D")]
		[Address(RVA = "0x35FBB90", Offset = "0x35FBB90", VA = "0x35FBB90", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003C57")]
	private sealed class _003CBuildCharacterWhenReady_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019A9D")]
		[FieldOffset(Offset = "0x8")]
		internal DynamicCharacterAvatar _0024this;

		[Token(Token = "0x4019A9E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019A9F")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4019AA0")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700198C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6018160")]
			[Address(RVA = "0x35FB1E0", Offset = "0x35FB1E0", VA = "0x35FB1E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700198D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6018161")]
			[Address(RVA = "0x35FB1E8", Offset = "0x35FB1E8", VA = "0x35FB1E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601815E")]
		[Address(RVA = "0x35F9A64", Offset = "0x35F9A64", VA = "0x35F9A64")]
		public _003CBuildCharacterWhenReady_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x601815F")]
		[Address(RVA = "0x35FB144", Offset = "0x35FB144", VA = "0x35FB144", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6018162")]
		[Address(RVA = "0x35FB1F0", Offset = "0x35FB1F0", VA = "0x35FB1F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6018163")]
		[Address(RVA = "0x35FB204", Offset = "0x35FB204", VA = "0x35FB204", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4019A5E")]
	[FieldOffset(Offset = "0x4C")]
	public UMADataEvent RecipeUpdated;

	[Token(Token = "0x4019A5F")]
	[FieldOffset(Offset = "0x50")]
	public RaceSetter activeRace;

	[Token(Token = "0x4019A60")]
	[FieldOffset(Offset = "0x54")]
	public ChangeRaceOptions defaultChangeRaceOptions;

	[Token(Token = "0x4019A61")]
	[FieldOffset(Offset = "0x58")]
	public ColorValueList characterColors;

	[Token(Token = "0x4019A62")]
	[FieldOffset(Offset = "0x5C")]
	public LoadOptions defaultLoadOptions;

	[Token(Token = "0x4019A63")]
	[FieldOffset(Offset = "0x60")]
	public bool ensureSharedColors;

	[NonSerialized]
	[Token(Token = "0x4019A64")]
	[FieldOffset(Offset = "0x64")]
	public List<string> assetBundlesUsedbyCharacter;

	[Token(Token = "0x4019A65")]
	[FieldOffset(Offset = "0x68")]
	public bool IsAsyncGeneration;

	[Token(Token = "0x4019A66")]
	[FieldOffset(Offset = "0x69")]
	private bool _buildCharacterEnabled;

	[Token(Token = "0x4019A67")]
	[FieldOffset(Offset = "0x6C")]
	private string cacheStateNull;

	[Token(Token = "0x4019A68")]
	[FieldOffset(Offset = "0x70")]
	private List<string> HiddenSlots;

	[Token(Token = "0x4019A69")]
	[FieldOffset(Offset = "0x74")]
	private bool _isFirstSettingsBuild;

	[Token(Token = "0x4019A6A")]
	[FieldOffset(Offset = "0x78")]
	private List<UMATextRecipe> _visibleRecipes;

	[Token(Token = "0x4019A6B")]
	[FieldOffset(Offset = "0x7C")]
	private List<KeyValuePair<SlotData, AdditiveInfo>> m_AdditiveSlots;

	[Token(Token = "0x4019A6C")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_RecipeSlotsStarts;

	[Token(Token = "0x1700197C")]
	public string RacePreset
	{
		[Token(Token = "0x60180F8")]
		[Address(RVA = "0x35F326C", Offset = "0x35F326C", VA = "0x35F326C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60180F9")]
		[Address(RVA = "0x35F3290", Offset = "0x35F3290", VA = "0x35F3290")]
		set
		{
		}
	}

	[Token(Token = "0x1700197D")]
	public Dictionary<string, List<UMATextRecipe>> AvailableRecipes
	{
		[Token(Token = "0x60180FA")]
		[Address(RVA = "0x35F32B8", Offset = "0x35F32B8", VA = "0x35F32B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700197E")]
	public List<string> CurrentWardrobeSlots
	{
		[Token(Token = "0x60180FC")]
		[Address(RVA = "0x35F3908", Offset = "0x35F3908", VA = "0x35F3908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700197F")]
	public List<ColorValue> ActiveColors
	{
		[Token(Token = "0x60180FD")]
		[Address(RVA = "0x35F3948", Offset = "0x35F3948", VA = "0x35F3948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001980")]
	public bool BuildCharacterEnabled
	{
		[Token(Token = "0x60180FE")]
		[Address(RVA = "0x35F3974", Offset = "0x35F3974", VA = "0x35F3974")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60180FF")]
		[Address(RVA = "0x35F397C", Offset = "0x35F397C", VA = "0x35F397C")]
		set
		{
		}
	}

	[Token(Token = "0x17001981")]
	private bool BuildUsingComponentSettings
	{
		[Token(Token = "0x6018100")]
		[Address(RVA = "0x35F3A88", Offset = "0x35F3A88", VA = "0x35F3A88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60180F7")]
	[Address(RVA = "0x35F302C", Offset = "0x35F302C", VA = "0x35F302C")]
	public DynamicCharacterAvatar()
	{
	}

	[Token(Token = "0x60180FB")]
	[Address(RVA = "0x35F3434", Offset = "0x35F3434", VA = "0x35F3434")]
	public void AddAvailableRaceRecipesDictionary(string raceName, ref Dictionary<string, UMATextRecipe> availableRecipesDict)
	{
	}

	[Token(Token = "0x6018101")]
	[Address(RVA = "0x35F3C1C", Offset = "0x35F3C1C", VA = "0x35F3C1C", Slot = "19")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6018102")]
	[Address(RVA = "0x35F3E58", Offset = "0x35F3E58", VA = "0x35F3E58", Slot = "40")]
	public void BuildCharacterImmediatly()
	{
	}

	[Token(Token = "0x6018103")]
	[Address(RVA = "0x35F4034", Offset = "0x35F4034", VA = "0x35F4034")]
	public void SetAnimator(Animator amtr)
	{
	}

	[Token(Token = "0x6018104")]
	[Address(RVA = "0x35F4014", Offset = "0x35F4014", VA = "0x35F4014")]
	private void BuildFromComponentSettingsCOSync()
	{
	}

	[Token(Token = "0x6018105")]
	[Address(RVA = "0x35F3B14", Offset = "0x35F3B14", VA = "0x35F3B14")]
	private IEnumerator BuildFromComponentSettingsCO()
	{
		return null;
	}

	[Token(Token = "0x6018106")]
	[Address(RVA = "0x35F40F0", Offset = "0x35F40F0", VA = "0x35F40F0")]
	private void SetActiveRace(bool allowGenderFallback = false)
	{
	}

	[Token(Token = "0x6018107")]
	[Address(RVA = "0x35F64E8", Offset = "0x35F64E8", VA = "0x35F64E8", Slot = "37")]
	public void ChangeRace(string racename, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults)
	{
	}

	[Token(Token = "0x6018108")]
	[Address(RVA = "0x35F6668", Offset = "0x35F6668", VA = "0x35F6668")]
	public void ChangeRace(RaceData race, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults)
	{
	}

	[Token(Token = "0x6018109")]
	[Address(RVA = "0x35F6D00", Offset = "0x35F6D00", VA = "0x35F6D00")]
	private void PerformRaceChange(RaceData race, ChangeRaceOptions customChangeRaceOptions = ChangeRaceOptions.useDefaults)
	{
	}

	[Token(Token = "0x601810A")]
	[Address(RVA = "0x35F71A0", Offset = "0x35F71A0", VA = "0x35F71A0")]
	protected UMATextRecipe FindSlotRecipe(string Slotname, string Recipename)
	{
		return null;
	}

	[Token(Token = "0x601810B")]
	[Address(RVA = "0x35F7584", Offset = "0x35F7584", VA = "0x35F7584", Slot = "32")]
	protected override UMATextRecipe FindSlotRecipe(string Recipename)
	{
		return null;
	}

	[Token(Token = "0x601810C")]
	[Address(RVA = "0x35F7694", Offset = "0x35F7694", VA = "0x35F7694", Slot = "33")]
	protected override string GetRecipeSlot(UMATextRecipe recipe)
	{
		return null;
	}

	[Token(Token = "0x601810D")]
	[Address(RVA = "0x35F7744", Offset = "0x35F7744", VA = "0x35F7744")]
	public string GetWardrobeItemName(string SlotName)
	{
		return null;
	}

	[Token(Token = "0x601810E")]
	[Address(RVA = "0x35F78D8", Offset = "0x35F78D8", VA = "0x35F78D8")]
	public void SetSlot(UMATextRecipe utr)
	{
	}

	[Token(Token = "0x601810F")]
	[Address(RVA = "0x35F7A6C", Offset = "0x35F7A6C", VA = "0x35F7A6C")]
	public void SetSlot(string Slotname, string Recipename)
	{
	}

	[Token(Token = "0x6018110")]
	[Address(RVA = "0x35F7BCC", Offset = "0x35F7BCC", VA = "0x35F7BCC", Slot = "35")]
	public override bool IsSlotVisible(string slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6018111")]
	[Address(RVA = "0x35F7DD0", Offset = "0x35F7DD0", VA = "0x35F7DD0", Slot = "43")]
	public void InitAsyncLoading(bool pre)
	{
	}

	[Token(Token = "0x6018112")]
	[Address(RVA = "0x35F7DD4", Offset = "0x35F7DD4", VA = "0x35F7DD4", Slot = "44")]
	public bool IsAsyncLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6018113")]
	[Address(RVA = "0x35F7DDC", Offset = "0x35F7DDC", VA = "0x35F7DDC")]
	private void ApplyCurrentWardrobeToNewRace()
	{
	}

	[Token(Token = "0x6018114")]
	[Address(RVA = "0x35F817C", Offset = "0x35F817C", VA = "0x35F817C")]
	public void LoadWardrobeSet(List<WardrobeSettings> wardrobeSet, bool clearExisting = false)
	{
	}

	[Token(Token = "0x6018115")]
	[Address(RVA = "0x35F8454", Offset = "0x35F8454", VA = "0x35F8454")]
	public OverlayColorData GetColor(string Name)
	{
		return null;
	}

	[Token(Token = "0x6018116")]
	[Address(RVA = "0x35F8554", Offset = "0x35F8554", VA = "0x35F8554")]
	public void SetColor(string SharedColorName, Color AlbedoColor, [Optional] Color MetallicRGB, float Gloss = 0f, bool UpdateTexture = false)
	{
	}

	[Token(Token = "0x6018117")]
	[Address(RVA = "0x35F86A8", Offset = "0x35F86A8", VA = "0x35F86A8", Slot = "38")]
	public void SetColor(string Name, OverlayColorData colorData, bool UpdateTexture = true)
	{
	}

	[Token(Token = "0x6018118")]
	[Address(RVA = "0x35F8B5C", Offset = "0x35F8B5C", VA = "0x35F8B5C", Slot = "39")]
	public void ForceUpdateColor()
	{
	}

	[Token(Token = "0x6018119")]
	[Address(RVA = "0x35F88E0", Offset = "0x35F88E0", VA = "0x35F88E0")]
	public void UpdateColors(bool triggerDirty = false)
	{
	}

	[Token(Token = "0x601811A")]
	[Address(RVA = "0x35F8B64", Offset = "0x35F8B64", VA = "0x35F8B64")]
	private OverlayColorData[] ImportSharedColors(OverlayColorData[] colorsToLoad, LoadOptions thisLoadOptions)
	{
		return null;
	}

	[Token(Token = "0x601811B")]
	[Address(RVA = "0x35F90A8", Offset = "0x35F90A8", VA = "0x35F90A8")]
	private List<string> GetBodyColorNames()
	{
		return null;
	}

	[Token(Token = "0x601811C")]
	[Address(RVA = "0x35F9068", Offset = "0x35F9068", VA = "0x35F9068")]
	public List<OverlayColorData> LoadBodyColors(OverlayColorData[] colorsToLoad, bool apply = false)
	{
		return null;
	}

	[Token(Token = "0x601811D")]
	[Address(RVA = "0x35F9088", Offset = "0x35F9088", VA = "0x35F9088")]
	public List<OverlayColorData> LoadWardrobeColors(OverlayColorData[] colorsToLoad, bool apply = false)
	{
		return null;
	}

	[Token(Token = "0x601811E")]
	[Address(RVA = "0x35F92A8", Offset = "0x35F92A8", VA = "0x35F92A8")]
	private List<OverlayColorData> LoadBodyOrWardrobeColors(OverlayColorData[] colorsToLoad, bool loadingBody = true, bool apply = false)
	{
		return null;
	}

	[Token(Token = "0x601811F")]
	[Address(RVA = "0x35F7088", Offset = "0x35F7088", VA = "0x35F7088")]
	public List<OverlayColorData> RestoreCachedBodyColors(bool apply = false, bool fullRestore = false)
	{
		return null;
	}

	[Token(Token = "0x6018120")]
	[Address(RVA = "0x35F70AC", Offset = "0x35F70AC", VA = "0x35F70AC")]
	public List<OverlayColorData> RestoreCachedWardrobeColors(bool apply = false, bool fullRestore = false)
	{
		return null;
	}

	[Token(Token = "0x6018121")]
	[Address(RVA = "0x35F9644", Offset = "0x35F9644", VA = "0x35F9644")]
	private List<OverlayColorData> RestoreCachedBodyOrWardrobeColors(bool restoringBody = true, bool apply = false, bool fullRestore = false)
	{
		return null;
	}

	[Token(Token = "0x6018122")]
	[Address(RVA = "0x35F70D0", Offset = "0x35F70D0", VA = "0x35F70D0")]
	private IEnumerator ImportSettingsCO(UMATextRecipe.DCSUniversalPackRecipe settingsToLoad, LoadOptions customLoadOptions = LoadOptions.useDefaults, bool forceDCSLoad = false)
	{
		return null;
	}

	[Token(Token = "0x6018123")]
	[Address(RVA = "0x35F3B98", Offset = "0x35F3B98", VA = "0x35F3B98")]
	private IEnumerator BuildCharacterWhenReady()
	{
		return null;
	}

	[Token(Token = "0x6018124")]
	[Address(RVA = "0x35F4FF0", Offset = "0x35F4FF0", VA = "0x35F4FF0", Slot = "41")]
	public void BuildCharacter()
	{
	}

	[Token(Token = "0x6018125")]
	[Address(RVA = "0x35F9A6C", Offset = "0x35F9A6C", VA = "0x35F9A6C")]
	private bool LoadCharacter(UMARecipeBase umaRecipe, List<UMAWardrobeRecipe> Replaces, UMATextRecipe[] umaAdditionalSerializedRecipes)
	{
		return default(bool);
	}

	[Token(Token = "0x6018126")]
	[Address(RVA = "0x35F686C", Offset = "0x35F686C", VA = "0x35F686C")]
	private void UnloadAvatar()
	{
	}

	[Token(Token = "0x6018127")]
	[Address(RVA = "0x35F9E68", Offset = "0x35F9E68", VA = "0x35F9E68")]
	private void FixAdditiveSlotInBaseSlots(UMAData.UMARecipe umaRecipe)
	{
	}

	[Token(Token = "0x6018128")]
	[Address(RVA = "0x35FA9EC", Offset = "0x35FA9EC", VA = "0x35FA9EC")]
	private void AddAdditiveToBaseSlot(SlotData[] slotDataList, int start, int end, SlotData slot, AdditiveInfo additiveInfo)
	{
	}

	[Token(Token = "0x6018129")]
	[Address(RVA = "0x35FA0B4", Offset = "0x35FA0B4", VA = "0x35FA0B4")]
	public void AddAdditionalSerializedRecipes(UMATextRecipe[] umaAdditionalSerializedRecipes)
	{
	}

	[Token(Token = "0x601812A")]
	[Address(RVA = "0x35FAB94", Offset = "0x35FAB94", VA = "0x35FAB94")]
	private void AddAdditiveSlots(UMATextRecipe[] recipes, List<int> recipeSlotStarts, SlotData[] slots, List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	[Token(Token = "0x601812B")]
	[Address(RVA = "0x35FB008", Offset = "0x35FB008", VA = "0x35FB008")]
	private void AddAdditiveToWardrobeSlot(SlotData[] slotDataList, int start, int end, SlotData slot, AdditiveInfo additiveInfo)
	{
	}

	[Token(Token = "0x601812C")]
	[Address(RVA = "0x35FAB0C", Offset = "0x35FAB0C", VA = "0x35FAB0C")]
	private void UpdateOverlayLimitSize(UMATextRecipe utr, UMAData.UMARecipe cachedRecipe)
	{
	}

	[Token(Token = "0x601812D")]
	[Address(RVA = "0x35FA7DC", Offset = "0x35FA7DC", VA = "0x35FA7DC")]
	private void RemoveHiddenSlots()
	{
	}
}
