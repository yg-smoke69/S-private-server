using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002853")]
public class UIHudSkillTemplateController : UIBaseController
{
	[Token(Token = "0x400F8AA")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSkillTemplateView m_View;

	[Token(Token = "0x400F8AB")]
	[FieldOffset(Offset = "0x2C")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F8AC")]
	[FieldOffset(Offset = "0x30")]
	private Camera m_Camera;

	[Token(Token = "0x400F8AD")]
	[FieldOffset(Offset = "0x34")]
	private float dist;

	[Token(Token = "0x400F8AE")]
	[FieldOffset(Offset = "0x38")]
	public string m_SkillType;

	[Token(Token = "0x400F8AF")]
	[FieldOffset(Offset = "0x3C")]
	private float m_NextLoopAnimTime;

	[Token(Token = "0x400F8B0")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsLoopAnim;

	[Token(Token = "0x400F8B1")]
	[FieldOffset(Offset = "0x44")]
	private float m_SkillCoolingTime;

	[Token(Token = "0x400F8B2")]
	[FieldOffset(Offset = "0x48")]
	private float m_SkillCDTime;

	[Token(Token = "0x400F8B3")]
	[FieldOffset(Offset = "0x4C")]
	private float m_SkillLeftTime;

	[Token(Token = "0x400F8B4")]
	[FieldOffset(Offset = "0x50")]
	private int m_SkillCDEndTime;

	[Token(Token = "0x400F8B5")]
	[FieldOffset(Offset = "0x54")]
	private bool m_ShowCDAnim;

	[Token(Token = "0x400F8B6")]
	[FieldOffset(Offset = "0x55")]
	private bool m_ShowPetCdAnim;

	[Token(Token = "0x400F8B7")]
	[FieldOffset(Offset = "0x58")]
	private float m_BanSkillTime;

	[Token(Token = "0x400F8B8")]
	[FieldOffset(Offset = "0x5C")]
	private float m_StartBanTime;

	[Token(Token = "0x400F8B9")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsBanned;

	[Token(Token = "0x400F8BA")]
	private const string TurtleDefaultIcon = "FF_UI_Pet_Turtle_Skill";

	[Token(Token = "0x400F8BB")]
	private const string ActiveSkillBg = "icon_ingame_KillFeast_BG";

	[Token(Token = "0x400F8BC")]
	[FieldOffset(Offset = "0x61")]
	private bool m_HasInitActiveSkill;

	[Token(Token = "0x400F8BD")]
	[FieldOffset(Offset = "0x62")]
	private bool m_IsActiveSkill;

	[Token(Token = "0x400F8BE")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_ActiveSkillDescOffset;

	[Token(Token = "0x400F8BF")]
	[FieldOffset(Offset = "0x70")]
	private int m_DefaultTemplateWidth;

	[Token(Token = "0x400F8C0")]
	[FieldOffset(Offset = "0x74")]
	private int m_DefaultTemplateHeight;

	[Token(Token = "0x400F8C1")]
	[FieldOffset(Offset = "0x78")]
	private int m_DefaultSkillBGWidth;

	[Token(Token = "0x400F8C2")]
	[FieldOffset(Offset = "0x7C")]
	private int m_DefaultSkillBGHeight;

	[Token(Token = "0x400F8C3")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 m_DefaultSkillLabelPos;

	[Token(Token = "0x400F8C4")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsPetSkill;

	[Token(Token = "0x400F8C5")]
	[FieldOffset(Offset = "0x89")]
	private bool m_IsOB;

	[Token(Token = "0x400F8C6")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_LevelAnimDelay;

	[Token(Token = "0x400F8C7")]
	[FieldOffset(Offset = "0x90")]
	private float m_LastServerTime;

	[Token(Token = "0x400F8C8")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapD;

	[Token(Token = "0x400F8C9")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapE;

	[Token(Token = "0x600FC10")]
	[Address(RVA = "0x16C9590", Offset = "0x16C9590", VA = "0x16C9590")]
	public UIHudSkillTemplateController()
	{
	}

	[Token(Token = "0x600FC11")]
	[Address(RVA = "0x16C9654", Offset = "0x16C9654", VA = "0x16C9654")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC12")]
	[Address(RVA = "0x16C96F8", Offset = "0x16C96F8", VA = "0x16C96F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC13")]
	[Address(RVA = "0x16C9D1C", Offset = "0x16C9D1C", VA = "0x16C9D1C")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x600FC14")]
	[Address(RVA = "0x16C9E20", Offset = "0x16C9E20", VA = "0x16C9E20", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FC15")]
	[Address(RVA = "0x16C9F30", Offset = "0x16C9F30", VA = "0x16C9F30")]
	public void OnReInit()
	{
	}

	[Token(Token = "0x600FC16")]
	[Address(RVA = "0x16CA410", Offset = "0x16CA410", VA = "0x16CA410")]
	public void RefreshSkillData(PetSkillLevelData data)
	{
	}

	[Token(Token = "0x600FC17")]
	[Address(RVA = "0x16CA84C", Offset = "0x16CA84C", VA = "0x16CA84C")]
	public void RefreshSkillData(AvatarSkillData data)
	{
	}

	[Token(Token = "0x600FC18")]
	[Address(RVA = "0x16CACAC", Offset = "0x16CACAC", VA = "0x16CACAC")]
	protected void SetEnhanced(uint skillLevel)
	{
	}

	[Token(Token = "0x600FC19")]
	[Address(RVA = "0x16CAD64", Offset = "0x16CAD64", VA = "0x16CAD64")]
	public void PlayLevelUpAnim()
	{
	}

	[Token(Token = "0x600FC1A")]
	[Address(RVA = "0x16CAEE8", Offset = "0x16CAEE8", VA = "0x16CAEE8")]
	public void SetActiveSkillIcon(bool isDynamic)
	{
	}

	[Token(Token = "0x600FC1B")]
	[Address(RVA = "0x16CB378", Offset = "0x16CB378", VA = "0x16CB378")]
	public void CheckSkillNeedShowCDAnim()
	{
	}

	[Token(Token = "0x600FC1C")]
	[Address(RVA = "0x16CB72C", Offset = "0x16CB72C", VA = "0x16CB72C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC1D")]
	[Address(RVA = "0x16CB790", Offset = "0x16CB790", VA = "0x16CB790")]
	private void TryGetCameraComponent()
	{
	}

	[Token(Token = "0x600FC1E")]
	[Address(RVA = "0x16CB8F4", Offset = "0x16CB8F4", VA = "0x16CB8F4")]
	public void OnShowMoveEffect(bool show)
	{
	}

	[Token(Token = "0x600FC1F")]
	[Address(RVA = "0x16CB98C", Offset = "0x16CB98C", VA = "0x16CB98C")]
	public void OnShowShootEffect(bool show)
	{
	}

	[Token(Token = "0x600FC20")]
	[Address(RVA = "0x16CBA24", Offset = "0x16CBA24", VA = "0x16CBA24")]
	public void OnPlayBrightAnim(string skillAnimType, bool animValue)
	{
	}

	[Token(Token = "0x600FC21")]
	[Address(RVA = "0x16CC438", Offset = "0x16CC438", VA = "0x16CC438")]
	public void OnPlayFlashAnim(string skillAnimType)
	{
	}

	[Token(Token = "0x600FC22")]
	[Address(RVA = "0x16CCA2C", Offset = "0x16CCA2C", VA = "0x16CCA2C")]
	public void OnPlaySpecialAnim(string skillAnimType, object[] data)
	{
	}

	[Token(Token = "0x600FC23")]
	[Address(RVA = "0x16CB5A4", Offset = "0x16CB5A4", VA = "0x16CB5A4")]
	public void OnPlayCoolDownAnim(float cdTime, int cdEndTime)
	{
	}

	[Token(Token = "0x600FC24")]
	[Address(RVA = "0x16CCE80", Offset = "0x16CCE80", VA = "0x16CCE80")]
	public void OnPetPlayCoolDownAnim(float cdTime, int leftTime)
	{
	}

	[Token(Token = "0x600FC25")]
	[Address(RVA = "0x16CCBC8", Offset = "0x16CCBC8", VA = "0x16CCBC8")]
	private void PlayTurtleDurableAnim(uint degree)
	{
	}

	[Token(Token = "0x600FC26")]
	[Address(RVA = "0x16CC998", Offset = "0x16CC998", VA = "0x16CC998")]
	private void InitFlashAnimState()
	{
	}

	[Token(Token = "0x600FC27")]
	[Address(RVA = "0x16CD00C", Offset = "0x16CD00C", VA = "0x16CD00C")]
	private void UpdateFlashAnimState()
	{
	}

	[Token(Token = "0x600FC28")]
	[Address(RVA = "0x16CC244", Offset = "0x16CC244", VA = "0x16CC244")]
	public void PlayBrightAnim(bool isFlash = false)
	{
	}

	[Token(Token = "0x600FC29")]
	[Address(RVA = "0x16CC354", Offset = "0x16CC354", VA = "0x16CC354")]
	public void ResetBrightAnim()
	{
	}

	[Token(Token = "0x600FC2A")]
	[Address(RVA = "0x16CD138", Offset = "0x16CD138", VA = "0x16CD138")]
	private void Update()
	{
	}

	[Token(Token = "0x600FC2B")]
	[Address(RVA = "0x16CD628", Offset = "0x16CD628", VA = "0x16CD628")]
	private void UpdateStreetBoySkill()
	{
	}

	[Token(Token = "0x600FC2C")]
	[Address(RVA = "0x16CD980", Offset = "0x16CD980", VA = "0x16CD980")]
	private void OnPress(GameObject go, bool value)
	{
	}

	[Token(Token = "0x600FC2D")]
	[Address(RVA = "0x16CDA50", Offset = "0x16CDA50", VA = "0x16CDA50")]
	private void OnChangeSilencedState(object[] param)
	{
	}

	[Token(Token = "0x600FC2E")]
	[Address(RVA = "0x16CD828", Offset = "0x16CD828", VA = "0x16CD828")]
	private void UpdateSilencedState()
	{
	}

	[Token(Token = "0x600FC2F")]
	[Address(RVA = "0x16CDC9C", Offset = "0x16CDC9C", VA = "0x16CDC9C")]
	private void _003CPlayLevelUpAnim_003Em__0()
	{
	}

	[Token(Token = "0x600FC30")]
	[Address(RVA = "0x16CDCEC", Offset = "0x16CDCEC", VA = "0x16CDCEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC31")]
	[Address(RVA = "0x16CDCF4", Offset = "0x16CDCF4", VA = "0x16CDCF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600FC32")]
	[Address(RVA = "0x16CDCFC", Offset = "0x16CDCFC", VA = "0x16CDCFC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
