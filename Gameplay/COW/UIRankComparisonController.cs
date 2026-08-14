using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AAF")]
public class UIRankComparisonController : UIPopupWindowController
{
	[Token(Token = "0x401067C")]
	[FieldOffset(Offset = "0x48")]
	private UIRankComparisonView m_View;

	[Token(Token = "0x401067D")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLadderMatch m_Model;

	[Token(Token = "0x401067E")]
	[FieldOffset(Offset = "0x50")]
	private List<UIRankComparisonFriendListItemController> m_ItemList;

	[Token(Token = "0x601177D")]
	[Address(RVA = "0x1AC5988", Offset = "0x1AC5988", VA = "0x1AC5988")]
	public UIRankComparisonController()
	{
	}

	[Token(Token = "0x601177E")]
	[Address(RVA = "0x1AC5A14", Offset = "0x1AC5A14", VA = "0x1AC5A14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601177F")]
	[Address(RVA = "0x1AC5AB8", Offset = "0x1AC5AB8", VA = "0x1AC5AB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011780")]
	[Address(RVA = "0x1AC6AB8", Offset = "0x1AC6AB8", VA = "0x1AC6AB8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011781")]
	[Address(RVA = "0x1AC637C", Offset = "0x1AC637C", VA = "0x1AC637C")]
	private void InitLadderInfo()
	{
	}

	[Token(Token = "0x6011782")]
	[Address(RVA = "0x1AC67E8", Offset = "0x1AC67E8", VA = "0x1AC67E8")]
	private void InitRankListInfo()
	{
	}

	[Token(Token = "0x6011783")]
	[Address(RVA = "0x1AC6C1C", Offset = "0x1AC6C1C", VA = "0x1AC6C1C")]
	private void OnBGClick()
	{
	}

	[Token(Token = "0x6011784")]
	[Address(RVA = "0x1AC6C80", Offset = "0x1AC6C80", VA = "0x1AC6C80")]
	private void OnGotoClick()
	{
	}

	[Token(Token = "0x6011785")]
	[Address(RVA = "0x1AC6DA4", Offset = "0x1AC6DA4", VA = "0x1AC6DA4")]
	private void OnShowClick()
	{
	}

	[Token(Token = "0x6011786")]
	[Address(RVA = "0x1AC6EB4", Offset = "0x1AC6EB4", VA = "0x1AC6EB4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011787")]
	[Address(RVA = "0x1AC6F18", Offset = "0x1AC6F18", VA = "0x1AC6F18")]
	private void OnShareClick()
	{
	}

	[Token(Token = "0x6011788")]
	[Address(RVA = "0x1AC7070", Offset = "0x1AC7070", VA = "0x1AC7070", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6011789")]
	[Address(RVA = "0x1AC720C", Offset = "0x1AC720C", VA = "0x1AC720C", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x601178A")]
	[Address(RVA = "0x1AC73F4", Offset = "0x1AC73F4", VA = "0x1AC73F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601178B")]
	[Address(RVA = "0x1AC73FC", Offset = "0x1AC73FC", VA = "0x1AC73FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x601178C")]
	[Address(RVA = "0x1AC7404", Offset = "0x1AC7404", VA = "0x1AC7404")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601178D")]
	[Address(RVA = "0x1AC740C", Offset = "0x1AC740C", VA = "0x1AC740C")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x601178E")]
	[Address(RVA = "0x1AC7414", Offset = "0x1AC7414", VA = "0x1AC7414")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
