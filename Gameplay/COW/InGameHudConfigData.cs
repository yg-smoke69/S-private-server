using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x200015B")]
public class InGameHudConfigData : SingletonModule<InGameHudConfigData>
{
	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, HudConfigItem> m_HudDefaultConfigDic;

	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, HudConfigItem> m_HudNewDefaultConfigDic;

	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, HudConfigItem> m_HudCustomizeConfigDic;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, HudConfigItem> m_HudNewCustomizeConfigDic;

	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, HudConfigItem> m_HudCurrentDefaultConfigDic;

	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, HudConfigItem> m_HudCurrentCustomizeConfigDic;

	[Token(Token = "0x40008C9")]
	private const string m_LeftFireKey = "HudAuxFire";

	[Token(Token = "0x40008CA")]
	private const string m_HudVersionKey = "HudVersion";

	[Token(Token = "0x1700013C")]
	public string HudVersionKey
	{
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2C7273C", Offset = "0x2C7273C", VA = "0x2C7273C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013D")]
	public Dictionary<string, HudConfigItem> HudDefaultConfigDic
	{
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2C727E0", Offset = "0x2C727E0", VA = "0x2C727E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013E")]
	public Dictionary<string, HudConfigItem> HudNewDefaultConfigDic
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2C72838", Offset = "0x2C72838", VA = "0x2C72838")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013F")]
	public Dictionary<string, HudConfigItem> HudCustomizeConfigDic
	{
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2C72890", Offset = "0x2C72890", VA = "0x2C72890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000140")]
	public Dictionary<string, HudConfigItem> HudNewCustomizeConfigDic
	{
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2C728E8", Offset = "0x2C728E8", VA = "0x2C728E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600081E")]
	[Address(RVA = "0x2C72600", Offset = "0x2C72600", VA = "0x2C72600")]
	public InGameHudConfigData()
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0x2C72940", Offset = "0x2C72940", VA = "0x2C72940", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0x2C73DE0", Offset = "0x2C73DE0", VA = "0x2C73DE0")]
	public void SetCurrent()
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0x2C73ECC", Offset = "0x2C73ECC", VA = "0x2C73ECC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x2C7400C", Offset = "0x2C7400C", VA = "0x2C7400C")]
	private void LoadDataFromJsonData(JsonData JObjRoot)
	{
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0x2C729C8", Offset = "0x2C729C8", VA = "0x2C729C8")]
	private void LoadNewDataFromConfig()
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x2C72B7C", Offset = "0x2C72B7C", VA = "0x2C72B7C")]
	private void LoadDataFromConfig()
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0x2C746AC", Offset = "0x2C746AC", VA = "0x2C746AC")]
	private void LoadCustomizeDataFromJsonData(JsonData JHud, uint setting)
	{
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x2C75660", Offset = "0x2C75660", VA = "0x2C75660")]
	private void LoadCustomizeDataFromJsonData(JsonData JHud)
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x2C73A50", Offset = "0x2C73A50", VA = "0x2C73A50")]
	private void LoadDataFromPlayerPref()
	{
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x2C73C18", Offset = "0x2C73C18", VA = "0x2C73C18")]
	private void LoadNewDataFromPlayerPref()
	{
	}

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x2C72F28", Offset = "0x2C72F28", VA = "0x2C72F28")]
	private void CheckOldVersion()
	{
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x2C7644C", Offset = "0x2C7644C", VA = "0x2C7644C")]
	public void RefreshDataFromPlayerPref()
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x2C764BC", Offset = "0x2C764BC", VA = "0x2C764BC")]
	public void SetDefaultHudConfigByStyle(bool isStyleNew)
	{
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x2C76C80", Offset = "0x2C76C80", VA = "0x2C76C80")]
	public bool HasCustomized(string hudName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x2C76E04", Offset = "0x2C76E04", VA = "0x2C76E04")]
	public HudConfigItem GetHudDefaultConfigByName(string HudName)
	{
		return null;
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x2C752D8", Offset = "0x2C752D8", VA = "0x2C752D8")]
	public HudConfigItem GetFirstDefaultConfigByName(string HudName)
	{
		return null;
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x2C753C0", Offset = "0x2C753C0", VA = "0x2C753C0")]
	public HudConfigItem GetSecondDefaultConfigByName(string HudName)
	{
		return null;
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x2C76EEC", Offset = "0x2C76EEC", VA = "0x2C76EEC")]
	public HudConfigItem GetHudCustomizeConfigByName(string HudName)
	{
		return null;
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x2C76FD4", Offset = "0x2C76FD4", VA = "0x2C76FD4")]
	public void ChangeCustomizedConfig(string HudName, HudConfigItem configItem)
	{
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x2C770DC", Offset = "0x2C770DC", VA = "0x2C770DC")]
	public void SaveDownloadedConfig(Dictionary<string, HudConfigItem> hud)
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x2C754A8", Offset = "0x2C754A8", VA = "0x2C754A8")]
	public void SaveCustomizedConfig(uint setting)
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x2C7625C", Offset = "0x2C7625C", VA = "0x2C7625C")]
	public void SaveCustomizedConfig([Optional] List<string> excludeList)
	{
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x2C76D60", Offset = "0x2C76D60", VA = "0x2C76D60")]
	public bool EqualToDefaultConfig(string key, HudConfigItem CustomizeConfig)
	{
		return default(bool);
	}
}
