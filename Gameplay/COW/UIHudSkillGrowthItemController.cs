using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002850")]
internal class UIHudSkillGrowthItemController : UIBaseController
{
	[Token(Token = "0x400F8A4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSkillGrowthItemView m_View;

	[Token(Token = "0x400F8A5")]
	[FieldOffset(Offset = "0x2C")]
	private AvatarSkillData m_Data;

	[Token(Token = "0x400F8A6")]
	[FieldOffset(Offset = "0x30")]
	private uint m_Skill2Learn;

	[Token(Token = "0x400F8A7")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsNewSkill;

	[Token(Token = "0x600FBF8")]
	[Address(RVA = "0x16C6548", Offset = "0x16C6548", VA = "0x16C6548")]
	public UIHudSkillGrowthItemController()
	{
	}

	[Token(Token = "0x600FBF9")]
	[Address(RVA = "0x16C65CC", Offset = "0x16C65CC", VA = "0x16C65CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FBFA")]
	[Address(RVA = "0x16C6674", Offset = "0x16C6674", VA = "0x16C6674", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FBFB")]
	[Address(RVA = "0x16C4108", Offset = "0x16C4108", VA = "0x16C4108")]
	public void SetView(uint skillID, bool isRecommended)
	{
	}

	[Token(Token = "0x600FBFC")]
	[Address(RVA = "0x16C426C", Offset = "0x16C426C", VA = "0x16C426C")]
	public void SetView(JJHIMAEGAPA skill)
	{
	}

	[Token(Token = "0x600FBFD")]
	[Address(RVA = "0x16C6890", Offset = "0x16C6890", VA = "0x16C6890")]
	private void SetViewInternal(bool newSkill)
	{
	}

	[Token(Token = "0x600FBFE")]
	[Address(RVA = "0x16C7438", Offset = "0x16C7438", VA = "0x16C7438")]
	private void OnSkillClick()
	{
	}

	[Token(Token = "0x600FBFF")]
	[Address(RVA = "0x16C7648", Offset = "0x16C7648", VA = "0x16C7648")]
	private void OnDragScrollClick()
	{
	}

	[Token(Token = "0x600FC00")]
	[Address(RVA = "0x16C787C", Offset = "0x16C787C", VA = "0x16C787C")]
	private void OnItemSelect(object[] data)
	{
	}

	[Token(Token = "0x600FC01")]
	[Address(RVA = "0x16C7A7C", Offset = "0x16C7A7C", VA = "0x16C7A7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
