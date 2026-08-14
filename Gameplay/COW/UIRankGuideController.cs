using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AB3")]
public class UIRankGuideController : UIBaseController
{
	[Token(Token = "0x4010686")]
	[FieldOffset(Offset = "0x28")]
	private UIRankGuideView m_View;

	[Token(Token = "0x4010687")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLadderMatch m_LadderModel;

	[Token(Token = "0x4010688")]
	[FieldOffset(Offset = "0x30")]
	private string label_tips_str;

	[Token(Token = "0x601179B")]
	[Address(RVA = "0x1AC88EC", Offset = "0x1AC88EC", VA = "0x1AC88EC")]
	public UIRankGuideController()
	{
	}

	[Token(Token = "0x601179C")]
	[Address(RVA = "0x1AC8970", Offset = "0x1AC8970", VA = "0x1AC8970")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601179D")]
	[Address(RVA = "0x1AC8A18", Offset = "0x1AC8A18", VA = "0x1AC8A18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601179E")]
	[Address(RVA = "0x1AC8C34", Offset = "0x1AC8C34", VA = "0x1AC8C34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601179F")]
	[Address(RVA = "0x1AC8C98", Offset = "0x1AC8C98", VA = "0x1AC8C98")]
	public void SetGuideView(UIGuideType type, string label_text, bool showMapBtnAnim = true)
	{
	}

	[Token(Token = "0x60117A0")]
	[Address(RVA = "0x1AC8ADC", Offset = "0x1AC8ADC", VA = "0x1AC8ADC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60117A1")]
	[Address(RVA = "0x1AC8E8C", Offset = "0x1AC8E8C", VA = "0x1AC8E8C")]
	public void PlayUnlockAnim()
	{
	}

	[Token(Token = "0x60117A2")]
	[Address(RVA = "0x1AC8F1C", Offset = "0x1AC8F1C", VA = "0x1AC8F1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60117A3")]
	[Address(RVA = "0x1AC8F24", Offset = "0x1AC8F24", VA = "0x1AC8F24")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
