using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace COW;

[Token(Token = "0x2000091")]
public class AvatarPropManager
{
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x8")]
	private GameObject m_PropGORight;

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_PropGOLeft;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_PropGORoot;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_PropGOHead;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_PropSkyBoard;

	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject m_PropWeapon;

	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x20")]
	private ResourceID m_CurrentPropWeapon;

	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_PropFireEffect;

	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_PropSecondaryWeapon;

	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x2C")]
	private ResourceID m_CurrentSecondaryPropWeapon;

	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_PropSecondaryFireEffect;

	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x34")]
	private ResourceID m_CurrentPropIDRight;

	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x38")]
	private ResourceID m_CurrentPropIDLeft;

	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x3C")]
	private ResourceID m_CurrentPropIDRoot;

	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x40")]
	private ResourceID m_CurrentPropIDHead;

	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x44")]
	private ITransformNode m_ParentRight;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x48")]
	private ITransformNode m_ParentRightForeArm;

	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x4C")]
	private ITransformNode m_ParentLeft;

	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x50")]
	private ITransformNode m_ParentLeftForeArm;

	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x54")]
	private ITransformNode m_ParentRoot;

	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x58")]
	private ITransformNode m_ParentHead;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x5C")]
	private Animator m_PropAnimator;

	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x60")]
	private PropAnimComponent m_LeftPropAnim;

	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x64")]
	private Entity m_OwnerEntity;

	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x68")]
	private bool hasweapon;

	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x69")]
	private bool isLocalPlayer;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x6C")]
	private UIMaleAvatar m_Avatar;

	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x70")]
	private bool m_ShowState;

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x23524A8", Offset = "0x23524A8", VA = "0x23524A8")]
	public AvatarPropManager(Entity ownerEntity, bool isLocal)
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x23525EC", Offset = "0x23525EC", VA = "0x23525EC")]
	public void ClearShowingWeapon()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x2352934", Offset = "0x2352934", VA = "0x2352934")]
	public bool IsDualWeild()
	{
		return default(bool);
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x2352A1C", Offset = "0x2352A1C", VA = "0x2352A1C")]
	public void RecycleCurrentProp()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x2352E38", Offset = "0x2352E38", VA = "0x2352E38")]
	public void SetPropItemVisibiltiy(bool visible)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x2353084", Offset = "0x2353084", VA = "0x2353084")]
	public void SetPropCastShadow()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x23533B8", Offset = "0x23533B8", VA = "0x23533B8")]
	private void ProcessCastShadow(GameObject go, ShadowCastingMode shadowCastingMode)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x23538DC", Offset = "0x23538DC", VA = "0x23538DC")]
	public void UpdatePropItem(PropertyData pData)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2354DB0", Offset = "0x2354DB0", VA = "0x2354DB0")]
	public bool CheckHasPropWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x2354E84", Offset = "0x2354E84", VA = "0x2354E84")]
	public void ShowPropWeaponState(bool flag)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2354EE4", Offset = "0x2354EE4", VA = "0x2354EE4")]
	public void ShowPropWeaponMesh(bool flag)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2355784", Offset = "0x2355784", VA = "0x2355784")]
	public void ShowPropWeapon(bool show = true)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2352728", Offset = "0x2352728", VA = "0x2352728")]
	public void UpdateWeaponItem(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weapondefaultid, bool secondary = false, bool isLeft = false)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x235722C", Offset = "0x235722C", VA = "0x235722C")]
	public void UpdateNoAnimWeaponItem(ResourceID weaponResId, ResourceID weaponDefaultId)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x235792C", Offset = "0x235792C", VA = "0x235792C")]
	public bool CheckHasWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2355A30", Offset = "0x2355A30", VA = "0x2355A30")]
	private void UpdateWeaponItem(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weapondefaultid, ref GameObject propWeapon, ref ResourceID currentPropWeapon, ref ITransformNode parent, ref GameObject propFireEffect, bool secondary, bool isLeft, bool fistUseForeArm)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2357984", Offset = "0x2357984", VA = "0x2357984")]
	public void UpdateSkyBoardItem(ResourceID skyboardid)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x2354A78", Offset = "0x2354A78", VA = "0x2354A78")]
	private void ResetObjectTransform(GameObject obj, bool isLeft = false)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x2357D68", Offset = "0x2357D68", VA = "0x2357D68")]
	public void StartShowPose(bool immediately = false)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x2357EF0", Offset = "0x2357EF0", VA = "0x2357EF0")]
	public void PlayClothesChangeAnim()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x2357FFC", Offset = "0x2357FFC", VA = "0x2357FFC")]
	public void StopClothesChangeAnim()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x2358138", Offset = "0x2358138", VA = "0x2358138")]
	public void StopShowPose(bool immediately = false)
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x23582C0", Offset = "0x23582C0", VA = "0x23582C0")]
	public void SetOverrideAnim(AnimationClip clip, AnimationClip baseClip)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x23585B0", Offset = "0x23585B0", VA = "0x23585B0")]
	public void RebindAnimator()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x23586AC", Offset = "0x23586AC", VA = "0x23586AC")]
	public void PlayLeftPropAnim(int index)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x23587B8", Offset = "0x23587B8", VA = "0x23587B8")]
	public bool PlayFistFireEffect(bool right)
	{
		return default(bool);
	}
}
