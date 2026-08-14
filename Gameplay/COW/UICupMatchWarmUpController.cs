using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002091")]
public class UICupMatchWarmUpController : UIPopupWindowController
{
	[Token(Token = "0x400CC1F")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchWarmUpView m_View;

	[Token(Token = "0x400CC20")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_Model;

	[Token(Token = "0x400CC21")]
	[FieldOffset(Offset = "0x50")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CC22")]
	private const string USE_ARENA_NAME = "0";

	[Token(Token = "0x400CC23")]
	[FieldOffset(Offset = "0x54")]
	private int m_GotoPage;

	[Token(Token = "0x600A7BD")]
	[Address(RVA = "0x11E78F0", Offset = "0x11E78F0", VA = "0x11E78F0")]
	public UICupMatchWarmUpController()
	{
	}

	[Token(Token = "0x600A7BE")]
	[Address(RVA = "0x11E78F8", Offset = "0x11E78F8", VA = "0x11E78F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7BF")]
	[Address(RVA = "0x11E79A0", Offset = "0x11E79A0", VA = "0x11E79A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A7C0")]
	[Address(RVA = "0x11E7C68", Offset = "0x11E7C68", VA = "0x11E7C68")]
	public void SetViewData(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A7C1")]
	[Address(RVA = "0x11E87C4", Offset = "0x11E87C4", VA = "0x11E87C4")]
	private void OnBtnCupMatchClick()
	{
	}

	[Token(Token = "0x600A7C2")]
	[Address(RVA = "0x11E8934", Offset = "0x11E8934", VA = "0x11E8934")]
	private void OnBtnArenaClick()
	{
	}

	[Token(Token = "0x600A7C3")]
	[Address(RVA = "0x11E8998", Offset = "0x11E8998", VA = "0x11E8998")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600A7C4")]
	[Address(RVA = "0x11E8AB0", Offset = "0x11E8AB0", VA = "0x11E8AB0")]
	private void OnFinishedPreMatch()
	{
	}

	[Token(Token = "0x600A7C5")]
	[Address(RVA = "0x11E8B14", Offset = "0x11E8B14", VA = "0x11E8B14")]
	private void OnFinishedDuringMatch()
	{
	}

	[Token(Token = "0x600A7C6")]
	[Address(RVA = "0x11E8B78", Offset = "0x11E8B78", VA = "0x11E8B78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
