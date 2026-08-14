using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200201B")]
internal class UIChampionshipRewardItemController : UIBaseController
{
	[Token(Token = "0x400C9A0")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipRewardItemView m_View;

	[Token(Token = "0x400C9A1")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x600A287")]
	[Address(RVA = "0x283A43C", Offset = "0x283A43C", VA = "0x283A43C")]
	public UIChampionshipRewardItemController()
	{
	}

	[Token(Token = "0x600A288")]
	[Address(RVA = "0x283A4C0", Offset = "0x283A4C0", VA = "0x283A4C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A289")]
	[Address(RVA = "0x283A568", Offset = "0x283A568", VA = "0x283A568", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A28A")]
	[Address(RVA = "0x283A6C4", Offset = "0x283A6C4", VA = "0x283A6C4")]
	public void SetViewData(BaseItemInfo data)
	{
	}

	[Token(Token = "0x600A28B")]
	[Address(RVA = "0x283A724", Offset = "0x283A724", VA = "0x283A724")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x600A28C")]
	[Address(RVA = "0x283A7CC", Offset = "0x283A7CC", VA = "0x283A7CC")]
	private void OnRewardBtnClick()
	{
	}

	[Token(Token = "0x600A28D")]
	[Address(RVA = "0x283A914", Offset = "0x283A914", VA = "0x283A914")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
