using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D3B")]
public class UISettingToggleBtnGroup : UIToggleButtonGroup
{
	[Token(Token = "0x40114B6")]
	[FieldOffset(Offset = "0x20")]
	public int[] m_Contents;

	[Token(Token = "0x40114B7")]
	[FieldOffset(Offset = "0x24")]
	public string m_SettingKey;

	[Token(Token = "0x40114B8")]
	[FieldOffset(Offset = "0x28")]
	public int m_DefaultContent;

	[Token(Token = "0x40114B9")]
	[FieldOffset(Offset = "0x2C")]
	public OnToggleGroupValueChange OnToggleValueChange;

	[Token(Token = "0x17001368")]
	public int settingValue
	{
		[Token(Token = "0x6012ECB")]
		[Address(RVA = "0x2050CE0", Offset = "0x2050CE0", VA = "0x2050CE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6012ECA")]
	[Address(RVA = "0x2050CD8", Offset = "0x2050CD8", VA = "0x2050CD8")]
	public UISettingToggleBtnGroup()
	{
	}

	[Token(Token = "0x6012ECC")]
	[Address(RVA = "0x2050DBC", Offset = "0x2050DBC", VA = "0x2050DBC", Slot = "4")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6012ECD")]
	[Address(RVA = "0x2050F64", Offset = "0x2050F64", VA = "0x2050F64", Slot = "5")]
	public override void OnSelectButton(UIToggleButton selectedButton)
	{
	}

	[Token(Token = "0x6012ECE")]
	[Address(RVA = "0x2051180", Offset = "0x2051180", VA = "0x2051180")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6012ECF")]
	[Address(RVA = "0x2051188", Offset = "0x2051188", VA = "0x2051188")]
	public void _003C_003EiFixBaseProxy_OnSelectButton(UIToggleButton P0)
	{
	}
}
