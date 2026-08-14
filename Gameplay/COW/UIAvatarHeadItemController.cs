using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A7")]
public class UIAvatarHeadItemController : UIEasyListItemController
{
	[Token(Token = "0x400E321")]
	[FieldOffset(Offset = "0x38")]
	private UIAvatarHeadItemView m_View;

	[Token(Token = "0x400E322")]
	[FieldOffset(Offset = "0x3C")]
	private AvatarProfile m_Itemdata;

	[Token(Token = "0x400E323")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ShowDebrisCnt;

	[Token(Token = "0x400E324")]
	[FieldOffset(Offset = "0x41")]
	private bool m_HideName;

	[Token(Token = "0x600D1C2")]
	[Address(RVA = "0x2A7F294", Offset = "0x2A7F294", VA = "0x2A7F294")]
	public UIAvatarHeadItemController()
	{
	}

	[Token(Token = "0x600D1C3")]
	[Address(RVA = "0x2A7F29C", Offset = "0x2A7F29C", VA = "0x2A7F29C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D1C4")]
	[Address(RVA = "0x2A7F344", Offset = "0x2A7F344", VA = "0x2A7F344", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D1C5")]
	[Address(RVA = "0x2A7F5A8", Offset = "0x2A7F5A8", VA = "0x2A7F5A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D1C6")]
	[Address(RVA = "0x2A7F60C", Offset = "0x2A7F60C", VA = "0x2A7F60C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D1C7")]
	[Address(RVA = "0x2A7F80C", Offset = "0x2A7F80C", VA = "0x2A7F80C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600D1C8")]
	[Address(RVA = "0x2A7F8C8", Offset = "0x2A7F8C8", VA = "0x2A7F8C8")]
	public void ShowDebrisCnt()
	{
	}

	[Token(Token = "0x600D1C9")]
	[Address(RVA = "0x2A7F924", Offset = "0x2A7F924", VA = "0x2A7F924")]
	public void HideName()
	{
	}

	[Token(Token = "0x600D1CA")]
	[Address(RVA = "0x2A7F980", Offset = "0x2A7F980", VA = "0x2A7F980", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D1CB")]
	[Address(RVA = "0x2A7FC98", Offset = "0x2A7FC98", VA = "0x2A7FC98")]
	public void RefreshLevelUpEffect()
	{
	}

	[Token(Token = "0x600D1CC")]
	[Address(RVA = "0x2A7FEBC", Offset = "0x2A7FEBC", VA = "0x2A7FEBC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D1CD")]
	[Address(RVA = "0x2A7FEC4", Offset = "0x2A7FEC4", VA = "0x2A7FEC4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D1CE")]
	[Address(RVA = "0x2A7FECC", Offset = "0x2A7FECC", VA = "0x2A7FECC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D1CF")]
	[Address(RVA = "0x2A7FED4", Offset = "0x2A7FED4", VA = "0x2A7FED4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
