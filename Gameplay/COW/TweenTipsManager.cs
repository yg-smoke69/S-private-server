using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023F5")]
public class TweenTipsManager : SingletonModule<TweenTipsManager>
{
	[Token(Token = "0x400E038")]
	private const int MAX_TIPS = 6;

	[Token(Token = "0x400E039")]
	private const int BASE_DEPTH = 900;

	[Token(Token = "0x400E03A")]
	[FieldOffset(Offset = "0xC")]
	private List<UICommonTweenTipsController> m_CachedCtrls;

	[Token(Token = "0x400E03B")]
	[FieldOffset(Offset = "0x10")]
	private int m_RunnigIndex;

	[Token(Token = "0x400E03C")]
	[FieldOffset(Offset = "0x14")]
	private int m_EmptyIndex;

	[Token(Token = "0x400E03D")]
	[FieldOffset(Offset = "0x18")]
	private int m_CurrentDepth;

	[Token(Token = "0x400E03E")]
	[FieldOffset(Offset = "0x1C")]
	public string ReturnToLobbyTips;

	[Token(Token = "0x600CAF8")]
	[Address(RVA = "0x23379A8", Offset = "0x23379A8", VA = "0x23379A8")]
	public TweenTipsManager()
	{
	}

	[Token(Token = "0x600CAF9")]
	[Address(RVA = "0x2337AB4", Offset = "0x2337AB4", VA = "0x2337AB4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600CAFA")]
	[Address(RVA = "0x2337C78", Offset = "0x2337C78", VA = "0x2337C78", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600CAFB")]
	[Address(RVA = "0x2337CD8", Offset = "0x2337CD8", VA = "0x2337CD8")]
	public void Clear()
	{
	}

	[Token(Token = "0x600CAFC")]
	[Address(RVA = "0x2337F4C", Offset = "0x2337F4C", VA = "0x2337F4C")]
	public void ShowTips(string tips, float holdOnTime = 0f)
	{
	}

	[Token(Token = "0x600CAFD")]
	[Address(RVA = "0x23382F8", Offset = "0x23382F8", VA = "0x23382F8")]
	public void ShowTips(BaseItemInfo itemInfo)
	{
	}

	[Token(Token = "0x600CAFE")]
	[Address(RVA = "0x233864C", Offset = "0x233864C", VA = "0x233864C")]
	public void ShowTips(ResourceID resId, uint cnt)
	{
	}

	[Token(Token = "0x600CAFF")]
	[Address(RVA = "0x23389B8", Offset = "0x23389B8", VA = "0x23389B8")]
	public void ShowTips(string text, List<ResourceID> iconResList)
	{
	}

	[Token(Token = "0x600CB00")]
	[Address(RVA = "0x2338D24", Offset = "0x2338D24", VA = "0x2338D24")]
	public void UpdateRunningIndex()
	{
	}

	[Token(Token = "0x600CB01")]
	[Address(RVA = "0x2338DA0", Offset = "0x2338DA0", VA = "0x2338DA0")]
	public void ShowReturnToLobbyTips()
	{
	}
}
