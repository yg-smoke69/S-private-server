using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C99")]
public abstract class FrontEndPreviewDetailSkillInfoPanelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<FrontEndPreviewDetailSkillInfoPanelBaseView>
{
	[Token(Token = "0x401107F")]
	[FieldOffset(Offset = "0x38")]
	private AvatarSkillData m_AvatarSkillData;

	[Token(Token = "0x4011080")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_DelayCallID;

	[Token(Token = "0x4011081")]
	private const int BGPADDDING = 14;

	[Token(Token = "0x6012A3B")]
	[Address(RVA = "0x104C578", Offset = "0x104C578", VA = "0x104C578")]
	protected FrontEndPreviewDetailSkillInfoPanelBaseController()
	{
	}

	[Token(Token = "0x6012A3C")]
	[Address(RVA = "0x104C5DC", Offset = "0x104C5DC", VA = "0x104C5DC", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012A3D")]
	[Address(RVA = "0x104C798", Offset = "0x104C798", VA = "0x104C798")]
	public void RefreshPetSkillInfo(uint skillID)
	{
	}

	[Token(Token = "0x6012A3E")]
	[Address(RVA = "0x104CEBC", Offset = "0x104CEBC", VA = "0x104CEBC")]
	public void RefreshAvatarSkillInfo(AvatarSkillData avatarSkillData)
	{
	}

	[Token(Token = "0x6012A3F")]
	[Address(RVA = "0x104CD10", Offset = "0x104CD10", VA = "0x104CD10")]
	private void SetBg()
	{
	}

	[Token(Token = "0x6012A40")]
	[Address(RVA = "0x104D24C", Offset = "0x104D24C", VA = "0x104D24C")]
	private void DescLabelCallBack(int lines)
	{
	}

	[Token(Token = "0x6012A41")]
	[Address(RVA = "0x104CB44", Offset = "0x104CB44", VA = "0x104CB44")]
	private void DelayHideDetail()
	{
	}

	[Token(Token = "0x6012A42")]
	[Address(RVA = "0x104D408", Offset = "0x104D408", VA = "0x104D408")]
	private void HideDetail()
	{
	}

	[Token(Token = "0x6012A43")]
	[Address(RVA = "0x104D570", Offset = "0x104D570", VA = "0x104D570")]
	private void OnSkillBtnClick()
	{
	}

	[Token(Token = "0x6012A44")]
	[Address(RVA = "0x104DC60", Offset = "0x104DC60", VA = "0x104DC60")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
