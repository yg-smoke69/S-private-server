using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D3D")]
public class UISettingToggleGroup : MonoBehaviour
{
	[Token(Token = "0x40114BA")]
	[FieldOffset(Offset = "0xC")]
	public UIToggle[] m_Toggles;

	[Token(Token = "0x40114BB")]
	[FieldOffset(Offset = "0x10")]
	public int[] m_Contents;

	[Token(Token = "0x40114BC")]
	[FieldOffset(Offset = "0x14")]
	public UILabel[] m_Labels;

	[Token(Token = "0x40114BD")]
	[FieldOffset(Offset = "0x18")]
	public string m_SettingKey;

	[Token(Token = "0x40114BE")]
	[FieldOffset(Offset = "0x1C")]
	public int m_DefaultContent;

	[Token(Token = "0x40114BF")]
	[FieldOffset(Offset = "0x20")]
	public bool isReloadingWorks;

	[Token(Token = "0x40114C0")]
	[FieldOffset(Offset = "0x21")]
	private bool isInitShow;

	[Token(Token = "0x40114C1")]
	[FieldOffset(Offset = "0x24")]
	private UIToggleValue[] m_ToggleValueItems;

	[Token(Token = "0x40114C2")]
	[FieldOffset(Offset = "0x28")]
	public OnToggleGroupValueChange OnToggleValueChange;

	[Token(Token = "0x40114C3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel m_LocTitle;

	[Token(Token = "0x40114C4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_OnLabel;

	[Token(Token = "0x40114C5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel m_OffLabel;

	[Token(Token = "0x40114C6")]
	[FieldOffset(Offset = "0x38")]
	public Color OnColor;

	[Token(Token = "0x40114C7")]
	[FieldOffset(Offset = "0x48")]
	public Color OffColor;

	[Token(Token = "0x40114C8")]
	[FieldOffset(Offset = "0x58")]
	private bool m_HasInit;

	[Token(Token = "0x6012ED4")]
	[Address(RVA = "0x2051190", Offset = "0x2051190", VA = "0x2051190")]
	public UISettingToggleGroup()
	{
	}

	[Token(Token = "0x6012ED5")]
	[Address(RVA = "0x2051198", Offset = "0x2051198", VA = "0x2051198")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012ED6")]
	[Address(RVA = "0x20514E8", Offset = "0x20514E8", VA = "0x20514E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012ED7")]
	[Address(RVA = "0x20517B4", Offset = "0x20517B4", VA = "0x20517B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6012ED8")]
	[Address(RVA = "0x2051984", Offset = "0x2051984", VA = "0x2051984")]
	public void SetNewKey(string on, string off)
	{
	}

	[Token(Token = "0x6012ED9")]
	[Address(RVA = "0x2051814", Offset = "0x2051814", VA = "0x2051814")]
	public void SetTogglesGroup()
	{
	}

	[Token(Token = "0x6012EDA")]
	[Address(RVA = "0x2051BF8", Offset = "0x2051BF8", VA = "0x2051BF8")]
	private void OnValueChange()
	{
	}

	[Token(Token = "0x6012EDB")]
	[Address(RVA = "0x20524C0", Offset = "0x20524C0", VA = "0x20524C0")]
	public void SetLocTitleKey(string locKey)
	{
	}

	[Token(Token = "0x6012EDC")]
	[Address(RVA = "0x2052650", Offset = "0x2052650", VA = "0x2052650")]
	public void SetToggleValue(int value)
	{
	}
}
