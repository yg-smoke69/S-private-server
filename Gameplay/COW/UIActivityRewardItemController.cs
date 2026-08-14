using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002497")]
public class UIActivityRewardItemController : UIBaseController
{
	[Token(Token = "0x400E2CB")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityRewardItemView m_View;

	[Token(Token = "0x400E2CC")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_data;

	[Token(Token = "0x400E2CD")]
	[FieldOffset(Offset = "0x30")]
	private bool enabledToggle;

	[Token(Token = "0x400E2CE")]
	[FieldOffset(Offset = "0x34")]
	private int m_index;

	[Token(Token = "0x600D108")]
	[Address(RVA = "0x2FBE9EC", Offset = "0x2FBE9EC", VA = "0x2FBE9EC")]
	public UIActivityRewardItemController()
	{
	}

	[Token(Token = "0x600D109")]
	[Address(RVA = "0x2FBEA78", Offset = "0x2FBEA78", VA = "0x2FBEA78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D10A")]
	[Address(RVA = "0x2FBEB1C", Offset = "0x2FBEB1C", VA = "0x2FBEB1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D10B")]
	[Address(RVA = "0x2FBECEC", Offset = "0x2FBECEC", VA = "0x2FBECEC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D10C")]
	[Address(RVA = "0x2FBED50", Offset = "0x2FBED50", VA = "0x2FBED50")]
	public void SetData(AwardDesc item, bool enableToggle = false)
	{
	}

	[Token(Token = "0x600D10D")]
	[Address(RVA = "0x2FBEF80", Offset = "0x2FBEF80", VA = "0x2FBEF80")]
	private void OnClickToggleItem()
	{
	}

	[Token(Token = "0x600D10E")]
	[Address(RVA = "0x2FBF190", Offset = "0x2FBF190", VA = "0x2FBF190")]
	public void SetItemIndex(int index)
	{
	}

	[Token(Token = "0x600D10F")]
	[Address(RVA = "0x2FBF1F0", Offset = "0x2FBF1F0", VA = "0x2FBF1F0")]
	private void OnClickItem()
	{
	}

	[Token(Token = "0x600D110")]
	[Address(RVA = "0x2FBF7B4", Offset = "0x2FBF7B4", VA = "0x2FBF7B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D111")]
	[Address(RVA = "0x2FBF7BC", Offset = "0x2FBF7BC", VA = "0x2FBF7BC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
