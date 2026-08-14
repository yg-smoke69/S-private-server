using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002734")]
public class UIHudDynamicSkillTemplateController : UIBaseController
{
	[Token(Token = "0x400F1ED")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDynamicSkillTemplateView m_View;

	[Token(Token = "0x400F1EE")]
	[FieldOffset(Offset = "0x2C")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F1EF")]
	[FieldOffset(Offset = "0x30")]
	private Camera m_Camera;

	[Token(Token = "0x400F1F0")]
	[FieldOffset(Offset = "0x34")]
	private float dist;

	[Token(Token = "0x400F1F1")]
	[FieldOffset(Offset = "0x38")]
	public string m_SkillType;

	[Token(Token = "0x400F1F2")]
	[FieldOffset(Offset = "0x3C")]
	private float m_NextLoopAnimTime;

	[Token(Token = "0x400F1F3")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsLoopAnim;

	[Token(Token = "0x400F1F4")]
	[FieldOffset(Offset = "0x44")]
	private float m_SkillCoolingTime;

	[Token(Token = "0x400F1F5")]
	[FieldOffset(Offset = "0x48")]
	private float m_SkillCDTime;

	[Token(Token = "0x400F1F6")]
	[FieldOffset(Offset = "0x4C")]
	private float m_SkillLeftTime;

	[Token(Token = "0x400F1F7")]
	[FieldOffset(Offset = "0x50")]
	private int m_SkillCDEndTime;

	[Token(Token = "0x400F1F8")]
	[FieldOffset(Offset = "0x54")]
	private bool m_ShowCDAnim;

	[Token(Token = "0x400F1F9")]
	[FieldOffset(Offset = "0x55")]
	private bool m_ShowPetCdAnim;

	[Token(Token = "0x400F1FA")]
	[FieldOffset(Offset = "0x58")]
	private float m_BanSkillTime;

	[Token(Token = "0x400F1FB")]
	[FieldOffset(Offset = "0x5C")]
	private float m_StartBanTime;

	[Token(Token = "0x400F1FC")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsBanned;

	[Token(Token = "0x400F1FD")]
	private const string TurtleDefaultIcon = "FF_UI_Pet_Turtle_Skill";

	[Token(Token = "0x400F1FE")]
	private const string ActiveSkillBg = "icon_ingame_KillFeast_BG";

	[Token(Token = "0x400F1FF")]
	[FieldOffset(Offset = "0x61")]
	private bool m_HasInitActiveSkill;

	[Token(Token = "0x400F200")]
	[FieldOffset(Offset = "0x62")]
	private bool m_IsActiveSkill;

	[Token(Token = "0x400F201")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_ActiveSkillDescOffset;

	[Token(Token = "0x400F202")]
	[FieldOffset(Offset = "0x70")]
	private int m_DefaultTemplateWidth;

	[Token(Token = "0x400F203")]
	[FieldOffset(Offset = "0x74")]
	private int m_DefaultTemplateHeight;

	[Token(Token = "0x400F204")]
	[FieldOffset(Offset = "0x78")]
	private int m_DefaultSkillBGWidth;

	[Token(Token = "0x400F205")]
	[FieldOffset(Offset = "0x7C")]
	private int m_DefaultSkillBGHeight;

	[Token(Token = "0x400F206")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 m_DefaultSkillLabelPos;

	[Token(Token = "0x400F207")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsPetSkill;

	[Token(Token = "0x400F208")]
	[FieldOffset(Offset = "0x89")]
	private bool m_IsOB;

	[Token(Token = "0x400F209")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_LevelAnimDelay;

	[Token(Token = "0x400F20A")]
	[FieldOffset(Offset = "0x90")]
	private float m_LastServerTime;

	[Token(Token = "0x400F20B")]
	[FieldOffset(Offset = "0x94")]
	private bool m_IsEmptySkill;

	[Token(Token = "0x400F20C")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapB;

	[Token(Token = "0x400F20D")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapC;

	[Token(Token = "0x600EEBC")]
	[Address(RVA = "0x1CD9248", Offset = "0x1CD9248", VA = "0x1CD9248")]
	public UIHudDynamicSkillTemplateController()
	{
	}

	[Token(Token = "0x600EEBD")]
	[Address(RVA = "0x1CD9314", Offset = "0x1CD9314", VA = "0x1CD9314")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EEBE")]
	[Address(RVA = "0x1CD93B8", Offset = "0x1CD93B8", VA = "0x1CD93B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EEBF")]
	[Address(RVA = "0x1CD99DC", Offset = "0x1CD99DC", VA = "0x1CD99DC")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x600EEC0")]
	[Address(RVA = "0x1CD9AE0", Offset = "0x1CD9AE0", VA = "0x1CD9AE0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EEC1")]
	[Address(RVA = "0x1CD9BF0", Offset = "0x1CD9BF0", VA = "0x1CD9BF0")]
	public void OnReInit()
	{
	}

	[Token(Token = "0x600EEC2")]
	[Address(RVA = "0x1CDA0EC", Offset = "0x1CDA0EC", VA = "0x1CDA0EC")]
	public void RefreshSkillData(AvatarSkillData data)
	{
	}

	[Token(Token = "0x600EEC3")]
	[Address(RVA = "0x1CDA7A8", Offset = "0x1CDA7A8", VA = "0x1CDA7A8")]
	protected void SetEnhanced(uint skillLevel)
	{
	}

	[Token(Token = "0x600EEC4")]
	[Address(RVA = "0x1CDA840", Offset = "0x1CDA840", VA = "0x1CDA840")]
	public void PlayLevelUpAnim()
	{
	}

	[Token(Token = "0x600EEC5")]
	[Address(RVA = "0x1CDA9C4", Offset = "0x1CDA9C4", VA = "0x1CDA9C4")]
	public void SetActiveSkillIcon(bool isDynamic)
	{
	}

	[Token(Token = "0x600EEC6")]
	[Address(RVA = "0x1CDAE54", Offset = "0x1CDAE54", VA = "0x1CDAE54")]
	public void CheckSkillNeedShowCDAnim()
	{
	}

	[Token(Token = "0x600EEC7")]
	[Address(RVA = "0x1CDB208", Offset = "0x1CDB208", VA = "0x1CDB208", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EEC8")]
	[Address(RVA = "0x1CDB26C", Offset = "0x1CDB26C", VA = "0x1CDB26C")]
	private void TryGetCameraComponent()
	{
	}

	[Token(Token = "0x600EEC9")]
	[Address(RVA = "0x1CDB3D0", Offset = "0x1CDB3D0", VA = "0x1CDB3D0")]
	public void OnShowMoveEffect(bool show)
	{
	}

	[Token(Token = "0x600EECA")]
	[Address(RVA = "0x1CDB468", Offset = "0x1CDB468", VA = "0x1CDB468")]
	public void OnShowShootEffect(bool show)
	{
	}

	[Token(Token = "0x600EECB")]
	[Address(RVA = "0x1CDB500", Offset = "0x1CDB500", VA = "0x1CDB500")]
	public void OnPlayBrightAnim(string skillAnimType, bool animValue)
	{
	}

	[Token(Token = "0x600EECC")]
	[Address(RVA = "0x1CDBF14", Offset = "0x1CDBF14", VA = "0x1CDBF14")]
	public void OnPlayFlashAnim(string skillAnimType)
	{
	}

	[Token(Token = "0x600EECD")]
	[Address(RVA = "0x1CDC508", Offset = "0x1CDC508", VA = "0x1CDC508")]
	public void OnPlaySpecialAnim(string skillAnimType, object[] data)
	{
	}

	[Token(Token = "0x600EECE")]
	[Address(RVA = "0x1CDB080", Offset = "0x1CDB080", VA = "0x1CDB080")]
	public void OnPlayCoolDownAnim(float cdTime, int cdEndTime)
	{
	}

	[Token(Token = "0x600EECF")]
	[Address(RVA = "0x1CDC95C", Offset = "0x1CDC95C", VA = "0x1CDC95C")]
	public void OnPetPlayCoolDownAnim(float cdTime, int leftTime)
	{
	}

	[Token(Token = "0x600EED0")]
	[Address(RVA = "0x1CDC6A4", Offset = "0x1CDC6A4", VA = "0x1CDC6A4")]
	private void PlayTurtleDurableAnim(uint degree)
	{
	}

	[Token(Token = "0x600EED1")]
	[Address(RVA = "0x1CDC474", Offset = "0x1CDC474", VA = "0x1CDC474")]
	private void InitFlashAnimState()
	{
	}

	[Token(Token = "0x600EED2")]
	[Address(RVA = "0x1CDCAE8", Offset = "0x1CDCAE8", VA = "0x1CDCAE8")]
	private void UpdateFlashAnimState()
	{
	}

	[Token(Token = "0x600EED3")]
	[Address(RVA = "0x1CDBD20", Offset = "0x1CDBD20", VA = "0x1CDBD20")]
	public void PlayBrightAnim(bool isFlash = false)
	{
	}

	[Token(Token = "0x600EED4")]
	[Address(RVA = "0x1CDBE30", Offset = "0x1CDBE30", VA = "0x1CDBE30")]
	public void ResetBrightAnim()
	{
	}

	[Token(Token = "0x600EED5")]
	[Address(RVA = "0x1CDCC14", Offset = "0x1CDCC14", VA = "0x1CDCC14")]
	private void Update()
	{
	}

	[Token(Token = "0x600EED6")]
	[Address(RVA = "0x1CDD104", Offset = "0x1CDD104", VA = "0x1CDD104")]
	private void UpdateStreetBoySkill()
	{
	}

	[Token(Token = "0x600EED7")]
	[Address(RVA = "0x1CDD45C", Offset = "0x1CDD45C", VA = "0x1CDD45C")]
	private void OnPress(GameObject go, bool value)
	{
	}

	[Token(Token = "0x600EED8")]
	[Address(RVA = "0x1CDD544", Offset = "0x1CDD544", VA = "0x1CDD544")]
	private void OnChangeSilencedState(object[] param)
	{
	}

	[Token(Token = "0x600EED9")]
	[Address(RVA = "0x1CDD304", Offset = "0x1CDD304", VA = "0x1CDD304")]
	private void UpdateSilencedState()
	{
	}

	[Token(Token = "0x600EEDA")]
	[Address(RVA = "0x1CDD790", Offset = "0x1CDD790", VA = "0x1CDD790")]
	private void _003CPlayLevelUpAnim_003Em__0()
	{
	}

	[Token(Token = "0x600EEDB")]
	[Address(RVA = "0x1CDD7E0", Offset = "0x1CDD7E0", VA = "0x1CDD7E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EEDC")]
	[Address(RVA = "0x1CDD7E8", Offset = "0x1CDD7E8", VA = "0x1CDD7E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600EEDD")]
	[Address(RVA = "0x1CDD7F0", Offset = "0x1CDD7F0", VA = "0x1CDD7F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
