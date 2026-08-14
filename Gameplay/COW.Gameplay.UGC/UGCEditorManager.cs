using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C36")]
internal class UGCEditorManager
{
	[Token(Token = "0x40064AF")]
	[FieldOffset(Offset = "0x8")]
	private readonly JPPGAJBAAKK m_OwnerGame;

	[Token(Token = "0x40064B0")]
	[FieldOffset(Offset = "0xC")]
	private byte[] _003CCachedProjectMetaDataBytes_003Ek__BackingField;

	[Token(Token = "0x40064B1")]
	[FieldOffset(Offset = "0x10")]
	private string _003CCachedProjectMetaDataJsonString_003Ek__BackingField;

	[Token(Token = "0x40064B2")]
	[FieldOffset(Offset = "0x14")]
	private byte[] _003CCachedProjectDataBytes_003Ek__BackingField;

	[Token(Token = "0x40064B3")]
	[FieldOffset(Offset = "0x18")]
	private byte[] _003CCachedRuntimeDataBytes_003Ek__BackingField;

	[Token(Token = "0x40064B4")]
	[FieldOffset(Offset = "0x1C")]
	private string _003CCachedRuntimeDebugDataJsonString_003Ek__BackingField;

	[Token(Token = "0x40064B5")]
	[FieldOffset(Offset = "0x20")]
	private EditorMiscData _003CCachedMiscData_003Ek__BackingField;

	[Token(Token = "0x40064B6")]
	[FieldOffset(Offset = "0x24")]
	private readonly EditorEntityData m_EditorEntityData;

	[Token(Token = "0x40064B7")]
	[FieldOffset(Offset = "0x28")]
	private IUGCEditor<List<JGIADJOKNHI>> m_graphEditor;

	[Token(Token = "0x40064B8")]
	[FieldOffset(Offset = "0x2C")]
	private IUGCEditor<HMHKAANAOPE> m_workflowEditor;

	[Token(Token = "0x40064B9")]
	[FieldOffset(Offset = "0x30")]
	private IUGCEditor<List<CEIJKFCIALJ>> m_entityEditor;

	[Token(Token = "0x40064BA")]
	[FieldOffset(Offset = "0x34")]
	private IUGCEditor<HBLLODDOMEH> m_hudEditor;

	[Token(Token = "0x40064BB")]
	[FieldOffset(Offset = "0x38")]
	private IUGCEditor<HEAABFEMIDG> m_mapEditor;

	[Token(Token = "0x40064BC")]
	[FieldOffset(Offset = "0x3C")]
	private KEMMDGJBJNO _003CSceneBuilder_003Ek__BackingField;

	[Token(Token = "0x40064BD")]
	[FieldOffset(Offset = "0x40")]
	private bool _003CHasSomethingToSave_003Ek__BackingField;

	[Token(Token = "0x40064BE")]
	[FieldOffset(Offset = "0x41")]
	private bool _003CHasCreatedAllEntityFromData_003Ek__BackingField;

	[Token(Token = "0x170007EF")]
	public byte[] CachedProjectMetaDataBytes
	{
		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0x2F5EE90", Offset = "0x2F5EE90", VA = "0x2F5EE90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D30")]
		[Address(RVA = "0x2F5EE98", Offset = "0x2F5EE98", VA = "0x2F5EE98")]
		private set
		{
		}
	}

	[Token(Token = "0x170007F0")]
	private string CachedProjectMetaDataJsonString
	{
		[Token(Token = "0x6005D31")]
		[Address(RVA = "0x2F5EEA0", Offset = "0x2F5EEA0", VA = "0x2F5EEA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D32")]
		[Address(RVA = "0x2F5EEA8", Offset = "0x2F5EEA8", VA = "0x2F5EEA8")]
		set
		{
		}
	}

	[Token(Token = "0x170007F1")]
	public byte[] CachedProjectDataBytes
	{
		[Token(Token = "0x6005D33")]
		[Address(RVA = "0x2F5EEB0", Offset = "0x2F5EEB0", VA = "0x2F5EEB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D34")]
		[Address(RVA = "0x2F5EEB8", Offset = "0x2F5EEB8", VA = "0x2F5EEB8")]
		private set
		{
		}
	}

	[Token(Token = "0x170007F2")]
	public byte[] CachedRuntimeDataBytes
	{
		[Token(Token = "0x6005D35")]
		[Address(RVA = "0x2F5EEC0", Offset = "0x2F5EEC0", VA = "0x2F5EEC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D36")]
		[Address(RVA = "0x2F5EEC8", Offset = "0x2F5EEC8", VA = "0x2F5EEC8")]
		private set
		{
		}
	}

	[Token(Token = "0x170007F3")]
	private string CachedRuntimeDebugDataJsonString
	{
		[Token(Token = "0x6005D37")]
		[Address(RVA = "0x2F5EED0", Offset = "0x2F5EED0", VA = "0x2F5EED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D38")]
		[Address(RVA = "0x2F5EED8", Offset = "0x2F5EED8", VA = "0x2F5EED8")]
		set
		{
		}
	}

	[Token(Token = "0x170007F4")]
	public EditorMiscData CachedMiscData
	{
		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x2F5EEE0", Offset = "0x2F5EEE0", VA = "0x2F5EEE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0x2F5EEE8", Offset = "0x2F5EEE8", VA = "0x2F5EEE8")]
		private set
		{
		}
	}

	[Token(Token = "0x170007F5")]
	public EditorEntityData EditorEntityData
	{
		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0x2F5C4D8", Offset = "0x2F5C4D8", VA = "0x2F5C4D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F6")]
	public KEMMDGJBJNO SceneBuilder
	{
		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0x2F5EEF0", Offset = "0x2F5EEF0", VA = "0x2F5EEF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0x2F5EE88", Offset = "0x2F5EE88", VA = "0x2F5EE88")]
		private set
		{
		}
	}

	[Token(Token = "0x170007F7")]
	public bool HasSomethingToSave
	{
		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0x2F5EEF8", Offset = "0x2F5EEF8", VA = "0x2F5EEF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0x2F5EF00", Offset = "0x2F5EF00", VA = "0x2F5EF00")]
		set
		{
		}
	}

	[Token(Token = "0x170007F8")]
	public bool HasCreatedAllEntityFromData
	{
		[Token(Token = "0x6005D40")]
		[Address(RVA = "0x2F5EF08", Offset = "0x2F5EF08", VA = "0x2F5EF08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005D41")]
		[Address(RVA = "0x2F5EF10", Offset = "0x2F5EF10", VA = "0x2F5EF10")]
		set
		{
		}
	}

	[Token(Token = "0x6005D2E")]
	[Address(RVA = "0x2F5EDBC", Offset = "0x2F5EDBC", VA = "0x2F5EDBC")]
	public UGCEditorManager(JPPGAJBAAKK ownerGame, IUGCEditor<List<JGIADJOKNHI>> graphEditor, IUGCEditor<HMHKAANAOPE> workflowEditor, IUGCEditor<List<CEIJKFCIALJ>> entityEditor, IUGCEditor<HBLLODDOMEH> hudEditor, IUGCEditor<HEAABFEMIDG> mapEditor)
	{
	}

	[Token(Token = "0x6005D42")]
	[Address(RVA = "0x2F5EF18", Offset = "0x2F5EF18", VA = "0x2F5EF18")]
	public bool LoadEditors(byte[] projectDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D43")]
	[Address(RVA = "0x2F5F884", Offset = "0x2F5F884", VA = "0x2F5F884")]
	public bool ReloadEditors()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D44")]
	[Address(RVA = "0x2F5FEB4", Offset = "0x2F5FEB4", VA = "0x2F5FEB4")]
	public bool LoadEditorsWithoutProjectData()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D45")]
	[Address(RVA = "0x2F5F498", Offset = "0x2F5F498", VA = "0x2F5F498")]
	public bool UnloadEditors()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D46")]
	[Address(RVA = "0x2F5FF18", Offset = "0x2F5FF18", VA = "0x2F5FF18")]
	public bool LoadProjectDataFromLocal(uint slotID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D47")]
	[Address(RVA = "0x2F6020C", Offset = "0x2F6020C", VA = "0x2F6020C")]
	public bool LoadProjectDataFromConfig()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D48")]
	[Address(RVA = "0x2F6067C", Offset = "0x2F6067C", VA = "0x2F6067C")]
	public bool ExportAllData()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D49")]
	[Address(RVA = "0x2F618BC", Offset = "0x2F618BC", VA = "0x2F618BC")]
	public bool SaveAllDataToLocal(uint slotID)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D4A")]
	[Address(RVA = "0x2F61B9C", Offset = "0x2F61B9C", VA = "0x2F61B9C")]
	public static bool ConvertOldDataAndSaveToLocal(uint slotID)
	{
		return default(bool);
	}
}
