using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B78")]
public class UITrainingCampMemberItemController : UIBaseController
{
	[Token(Token = "0x4010A4F")]
	[FieldOffset(Offset = "0x28")]
	private UITrainingCampMemberItemView m_View;

	[Token(Token = "0x4010A50")]
	[FieldOffset(Offset = "0x2C")]
	private AccountInfoWithChummyState m_CurrentAccountInfoWithChummyState;

	[Token(Token = "0x4010A51")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_AccountId;

	[Token(Token = "0x4010A52")]
	[FieldOffset(Offset = "0x38")]
	private UIModelChummy m_ModelChummy;

	[Token(Token = "0x6011F2F")]
	[Address(RVA = "0x2B08FA4", Offset = "0x2B08FA4", VA = "0x2B08FA4")]
	public UITrainingCampMemberItemController()
	{
	}

	[Token(Token = "0x6011F30")]
	[Address(RVA = "0x2B09028", Offset = "0x2B09028", VA = "0x2B09028")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F31")]
	[Address(RVA = "0x2B090CC", Offset = "0x2B090CC", VA = "0x2B090CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F32")]
	[Address(RVA = "0x2B03268", Offset = "0x2B03268", VA = "0x2B03268")]
	public void SetData(AccountInfoWithChummyState CurrentInfo)
	{
	}

	[Token(Token = "0x6011F33")]
	[Address(RVA = "0x2B09408", Offset = "0x2B09408", VA = "0x2B09408")]
	private void RefreshStateNone()
	{
	}

	[Token(Token = "0x6011F34")]
	[Address(RVA = "0x2B09880", Offset = "0x2B09880", VA = "0x2B09880")]
	private void RefreshStateAlreadyBe()
	{
	}

	[Token(Token = "0x6011F35")]
	[Address(RVA = "0x2B095F8", Offset = "0x2B095F8", VA = "0x2B095F8")]
	private void RefreshStateWaitBroken()
	{
	}

	[Token(Token = "0x6011F36")]
	[Address(RVA = "0x2B09D28", Offset = "0x2B09D28", VA = "0x2B09D28")]
	private void OnClickHeadPic()
	{
	}

	[Token(Token = "0x6011F37")]
	[Address(RVA = "0x2B0A430", Offset = "0x2B0A430", VA = "0x2B0A430")]
	private void OnClickBreak(object obj)
	{
	}

	[Token(Token = "0x6011F38")]
	[Address(RVA = "0x2B0AA28", Offset = "0x2B0AA28", VA = "0x2B0AA28")]
	private void OnClickRevoke(object obj)
	{
	}

	[Token(Token = "0x6011F39")]
	[Address(RVA = "0x2B0AAD0", Offset = "0x2B0AAD0", VA = "0x2B0AAD0")]
	private void OnClickBreakBtn()
	{
	}

	[Token(Token = "0x6011F3A")]
	[Address(RVA = "0x2B0AB78", Offset = "0x2B0AB78", VA = "0x2B0AB78")]
	private void OnClickAddBtn()
	{
	}

	[Token(Token = "0x6011F3B")]
	[Address(RVA = "0x2B0AC88", Offset = "0x2B0AC88", VA = "0x2B0AC88")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x6011F3C")]
	[Address(RVA = "0x2B0AD08", Offset = "0x2B0AD08", VA = "0x2B0AD08")]
	private void OnClickGraduateBtn()
	{
	}

	[Token(Token = "0x6011F3D")]
	[Address(RVA = "0x2B0ADAC", Offset = "0x2B0ADAC", VA = "0x2B0ADAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
