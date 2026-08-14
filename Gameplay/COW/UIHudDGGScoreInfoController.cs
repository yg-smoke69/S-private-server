using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200272E")]
public class UIHudDGGScoreInfoController : UIBaseController
{
	[Token(Token = "0x400F1C7")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDGGScoreInfoView m_View;

	[Token(Token = "0x170011BB")]
	private int CurrentScore
	{
		[Token(Token = "0x600EE92")]
		[Address(RVA = "0x1CCD548", Offset = "0x1CCD548", VA = "0x1CCD548")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600EE8B")]
	[Address(RVA = "0x1CCD210", Offset = "0x1CCD210", VA = "0x1CCD210")]
	public UIHudDGGScoreInfoController()
	{
	}

	[Token(Token = "0x600EE8C")]
	[Address(RVA = "0x1CCD294", Offset = "0x1CCD294", VA = "0x1CCD294")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE8D")]
	[Address(RVA = "0x1CCD338", Offset = "0x1CCD338", VA = "0x1CCD338", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE8E")]
	[Address(RVA = "0x1CCD730", Offset = "0x1CCD730", VA = "0x1CCD730", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE8F")]
	[Address(RVA = "0x1CCD8CC", Offset = "0x1CCD8CC", VA = "0x1CCD8CC")]
	private void OnScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EE90")]
	[Address(RVA = "0x1CCDB3C", Offset = "0x1CCDB3C", VA = "0x1CCDB3C")]
	private void OnLeadingScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EE91")]
	[Address(RVA = "0x1CCD678", Offset = "0x1CCD678", VA = "0x1CCD678")]
	private void UpdateScore(int score)
	{
	}

	[Token(Token = "0x600EE93")]
	[Address(RVA = "0x1CCDC7C", Offset = "0x1CCDC7C", VA = "0x1CCDC7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE94")]
	[Address(RVA = "0x1CCDC84", Offset = "0x1CCDC84", VA = "0x1CCDC84")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
