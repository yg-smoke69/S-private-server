using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B50")]
public class UISPHudTeamMatchResultController : UIBaseController
{
	[Token(Token = "0x401098F")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudTeamMatchResultView m_View;

	[Token(Token = "0x6011D66")]
	[Address(RVA = "0x149515C", Offset = "0x149515C", VA = "0x149515C")]
	public UISPHudTeamMatchResultController()
	{
	}

	[Token(Token = "0x6011D67")]
	[Address(RVA = "0x14951E0", Offset = "0x14951E0", VA = "0x14951E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D68")]
	[Address(RVA = "0x1495288", Offset = "0x1495288", VA = "0x1495288", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D69")]
	[Address(RVA = "0x1495DFC", Offset = "0x1495DFC", VA = "0x1495DFC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D6A")]
	[Address(RVA = "0x1495F98", Offset = "0x1495F98", VA = "0x1495F98")]
	private void OnNextBtnClick()
	{
	}

	[Token(Token = "0x6011D6B")]
	[Address(RVA = "0x14960F8", Offset = "0x14960F8", VA = "0x14960F8")]
	private void OnDetailBtnClick()
	{
	}

	[Token(Token = "0x6011D6C")]
	[Address(RVA = "0x1496258", Offset = "0x1496258", VA = "0x1496258")]
	private void OnBackBtnClick()
	{
	}

	[Token(Token = "0x6011D6D")]
	[Address(RVA = "0x14963F4", Offset = "0x14963F4", VA = "0x14963F4")]
	private void DetailBtnTriggered(object[] data)
	{
	}

	[Token(Token = "0x6011D6E")]
	[Address(RVA = "0x149645C", Offset = "0x149645C", VA = "0x149645C")]
	private void NextBtnTriggered(object[] data)
	{
	}

	[Token(Token = "0x6011D6F")]
	[Address(RVA = "0x149578C", Offset = "0x149578C", VA = "0x149578C")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6011D70")]
	[Address(RVA = "0x14964C4", Offset = "0x14964C4", VA = "0x14964C4")]
	private void SetTop1View(ResultTeamData res)
	{
	}

	[Token(Token = "0x6011D71")]
	[Address(RVA = "0x1496840", Offset = "0x1496840", VA = "0x1496840")]
	private void SetTop2View(ResultTeamData res)
	{
	}

	[Token(Token = "0x6011D72")]
	[Address(RVA = "0x1496BBC", Offset = "0x1496BBC", VA = "0x1496BBC")]
	private void SetTop3View(ResultTeamData res)
	{
	}

	[Token(Token = "0x6011D73")]
	[Address(RVA = "0x1496F38", Offset = "0x1496F38", VA = "0x1496F38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D74")]
	[Address(RVA = "0x1496F40", Offset = "0x1496F40", VA = "0x1496F40")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
