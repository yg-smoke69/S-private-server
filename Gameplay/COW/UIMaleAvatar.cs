using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FCD")]
public class UIMaleAvatar : UIStatedAvatar
{
	[Token(Token = "0x2001FCE")]
	private sealed class _003CSetMatchResultAnimState_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C785")]
		[FieldOffset(Offset = "0x8")]
		internal AnimatorStateInfo _003Cstate_003E__0;

		[Token(Token = "0x400C786")]
		[FieldOffset(Offset = "0x2C")]
		internal string _003CtriggerName_003E__0;

		[Token(Token = "0x400C787")]
		[FieldOffset(Offset = "0x30")]
		internal UIMaleAvatar _0024this;

		[Token(Token = "0x400C788")]
		[FieldOffset(Offset = "0x34")]
		internal object _0024current;

		[Token(Token = "0x400C789")]
		[FieldOffset(Offset = "0x38")]
		internal bool _0024disposing;

		[Token(Token = "0x400C78A")]
		[FieldOffset(Offset = "0x3C")]
		internal int _0024PC;

		[Token(Token = "0x17000FAC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009F33")]
			[Address(RVA = "0x18E9F10", Offset = "0x18E9F10", VA = "0x18E9F10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FAD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009F34")]
			[Address(RVA = "0x18E9F18", Offset = "0x18E9F18", VA = "0x18E9F18", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009F31")]
		[Address(RVA = "0x18E9430", Offset = "0x18E9430", VA = "0x18E9430")]
		public _003CSetMatchResultAnimState_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009F32")]
		[Address(RVA = "0x18E9BF8", Offset = "0x18E9BF8", VA = "0x18E9BF8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009F35")]
		[Address(RVA = "0x18E9F20", Offset = "0x18E9F20", VA = "0x18E9F20", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009F36")]
		[Address(RVA = "0x18E9F34", Offset = "0x18E9F34", VA = "0x18E9F34", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C77B")]
	[FieldOffset(Offset = "0x0")]
	public static UIMaleAvatar LocalAvatar;

	[Token(Token = "0x400C77C")]
	[FieldOffset(Offset = "0x1A8")]
	private GameObject m_PlaneGO;

	[Token(Token = "0x400C77D")]
	private const float MATCHRESULT_WAIT_ANIM_TIME = 2f;

	[Token(Token = "0x400C77E")]
	private const float MATCHRESULT_STAND_ANIM_TIME = 8f;

	[Token(Token = "0x400C77F")]
	[FieldOffset(Offset = "0x1AC")]
	private float m_MatchResultPlayTime;

	[Token(Token = "0x400C780")]
	[FieldOffset(Offset = "0x1B0")]
	private bool m_IsPlayMatchResultShow;

	[Token(Token = "0x400C781")]
	[FieldOffset(Offset = "0x1B1")]
	private bool m_MatchResultNeedSwapAnim;

	[Token(Token = "0x400C782")]
	[FieldOffset(Offset = "0x1B4")]
	private float m_MatchResutlAnimSwapTime;

	[Token(Token = "0x400C783")]
	[FieldOffset(Offset = "0x1B8")]
	private GunType m_MatchResultGunType;

	[Token(Token = "0x400C784")]
	[FieldOffset(Offset = "0x1BC")]
	private Renderer[] m_VFXRenderersWithAnimationHide;

	[Token(Token = "0x17000FAB")]
	public bool IsAvatarReady
	{
		[Token(Token = "0x6009F09")]
		[Address(RVA = "0x18E5F8C", Offset = "0x18E5F8C", VA = "0x18E5F8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009F08")]
	[Address(RVA = "0x18E5F84", Offset = "0x18E5F84", VA = "0x18E5F84")]
	public UIMaleAvatar()
	{
	}

	[Token(Token = "0x6009F0A")]
	[Address(RVA = "0x18E5FE4", Offset = "0x18E5FE4", VA = "0x18E5FE4")]
	public static UIMaleAvatar GetLocalAvatar()
	{
		return null;
	}

	[Token(Token = "0x6009F0B")]
	[Address(RVA = "0x18E612C", Offset = "0x18E612C", VA = "0x18E612C")]
	private static void SetLocalAvatar(UIMaleAvatar s)
	{
	}

	[Token(Token = "0x6009F0C")]
	[Address(RVA = "0x18E63AC", Offset = "0x18E63AC", VA = "0x18E63AC")]
	public static UIMaleAvatar CreateAvatar(bool female)
	{
		return null;
	}

	[Token(Token = "0x6009F0D")]
	[Address(RVA = "0x18E6568", Offset = "0x18E6568", VA = "0x18E6568")]
	public void InitAvatarWithPlanarShadow(bool isLocal, Camera camera, GameObject avatarLightGo, Transform shadowPlane)
	{
	}

	[Token(Token = "0x6009F0E")]
	[Address(RVA = "0x18E681C", Offset = "0x18E681C", VA = "0x18E681C", Slot = "24")]
	public override void InitAvatar(bool isLocal, bool isPreviewAvatar = false, int textureScale = 1)
	{
	}

	[Token(Token = "0x6009F0F")]
	[Address(RVA = "0x18E6B94", Offset = "0x18E6B94", VA = "0x18E6B94")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6009F10")]
	[Address(RVA = "0x18E6C0C", Offset = "0x18E6C0C", VA = "0x18E6C0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009F11")]
	[Address(RVA = "0x18E6D80", Offset = "0x18E6D80", VA = "0x18E6D80")]
	private void OnQualityChanged(object[] data)
	{
	}

	[Token(Token = "0x6009F12")]
	[Address(RVA = "0x18E6DF8", Offset = "0x18E6DF8", VA = "0x18E6DF8")]
	public void SetLightVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6009F13")]
	[Address(RVA = "0x18E6F00", Offset = "0x18E6F00", VA = "0x18E6F00")]
	public void SetLightLayer(int layer)
	{
	}

	[Token(Token = "0x6009F14")]
	[Address(RVA = "0x18E7058", Offset = "0x18E7058", VA = "0x18E7058", Slot = "28")]
	protected override void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	[Token(Token = "0x6009F15")]
	[Address(RVA = "0x18E747C", Offset = "0x18E747C", VA = "0x18E747C")]
	public void SetCastShadow(bool castShadow, EFrontendPlannarShadowType ePlannarShadowType = EFrontendPlannarShadowType.Main)
	{
	}

	[Token(Token = "0x6009F16")]
	[Address(RVA = "0x18E7724", Offset = "0x18E7724", VA = "0x18E7724")]
	public void SetAvatarPlaneShow(bool isShow)
	{
	}

	[Token(Token = "0x6009F17")]
	[Address(RVA = "0x18E6A34", Offset = "0x18E6A34", VA = "0x18E6A34")]
	private void InitPlaneGo()
	{
	}

	[Token(Token = "0x6009F18")]
	[Address(RVA = "0x18E782C", Offset = "0x18E782C", VA = "0x18E782C")]
	public void StartShowGachaPose()
	{
	}

	[Token(Token = "0x6009F19")]
	[Address(RVA = "0x18E7880", Offset = "0x18E7880", VA = "0x18E7880")]
	public void SetAvatarData(UIModelAvatarBase.AvatarData aData, uint collectionid = 0u)
	{
	}

	[Token(Token = "0x6009F1A")]
	[Address(RVA = "0x18E7A4C", Offset = "0x18E7A4C", VA = "0x18E7A4C")]
	public void OnClothUpdate(object[] data)
	{
	}

	[Token(Token = "0x6009F1B")]
	[Address(RVA = "0x18E7CC4", Offset = "0x18E7CC4", VA = "0x18E7CC4")]
	public void SetForceChangeRace()
	{
	}

	[Token(Token = "0x6009F1C")]
	[Address(RVA = "0x18E7DDC", Offset = "0x18E7DDC", VA = "0x18E7DDC")]
	public void NewResetToModelCurrentAvatar()
	{
	}

	[Token(Token = "0x6009F1D")]
	[Address(RVA = "0x18E8468", Offset = "0x18E8468", VA = "0x18E8468")]
	public void SetForceChangeRaceFlag()
	{
	}

	[Token(Token = "0x6009F1E")]
	[Address(RVA = "0x18E80B4", Offset = "0x18E80B4", VA = "0x18E80B4")]
	public void ResetToModelCurrentAvatar(bool resetcollection = true)
	{
	}

	[Token(Token = "0x6009F1F")]
	[Address(RVA = "0x18E84D0", Offset = "0x18E84D0", VA = "0x18E84D0")]
	public void InitMatchResultTeammatesAnim(bool win, bool hasWeapon, bool isKnife, GunType gunType)
	{
	}

	[Token(Token = "0x6009F20")]
	[Address(RVA = "0x18E8DFC", Offset = "0x18E8DFC", VA = "0x18E8DFC")]
	public void InitMatchResultMVPAnim(bool win)
	{
	}

	[Token(Token = "0x6009F21")]
	[Address(RVA = "0x18E87C8", Offset = "0x18E87C8", VA = "0x18E87C8")]
	public void ReplaceAvatarMatchResultFacialExpressionAnim(bool win, bool mvp, uint weapon)
	{
	}

	[Token(Token = "0x6009F22")]
	[Address(RVA = "0x18E8EFC", Offset = "0x18E8EFC", VA = "0x18E8EFC")]
	public void PlayMatchResultAnim()
	{
	}

	[Token(Token = "0x6009F23")]
	[Address(RVA = "0x18E9038", Offset = "0x18E9038", VA = "0x18E9038")]
	public void PlayMVPAnim()
	{
	}

	[Token(Token = "0x6009F24")]
	[Address(RVA = "0x18E90E8", Offset = "0x18E90E8", VA = "0x18E90E8")]
	public void PlayGroupAnimAsMVP(ResourceID resID)
	{
	}

	[Token(Token = "0x6009F25")]
	[Address(RVA = "0x18E92D8", Offset = "0x18E92D8", VA = "0x18E92D8")]
	public void SkipMVPAnim()
	{
	}

	[Token(Token = "0x6009F26")]
	[Address(RVA = "0x18E8F6C", Offset = "0x18E8F6C", VA = "0x18E8F6C")]
	private IEnumerator SetMatchResultAnimState()
	{
		return null;
	}

	[Token(Token = "0x6009F27")]
	[Address(RVA = "0x18E9438", Offset = "0x18E9438", VA = "0x18E9438")]
	private void UpdateMatchResultAnim()
	{
	}

	[Token(Token = "0x6009F28")]
	[Address(RVA = "0x18E9654", Offset = "0x18E9654", VA = "0x18E9654", Slot = "39")]
	protected override void DoUpdate()
	{
	}

	[Token(Token = "0x6009F29")]
	[Address(RVA = "0x18E96D0", Offset = "0x18E96D0", VA = "0x18E96D0")]
	public void SetAvatarForward(bool isForward)
	{
	}

	[Token(Token = "0x6009F2A")]
	[Address(RVA = "0x18E9828", Offset = "0x18E9828", VA = "0x18E9828")]
	public void AnimationHide(int hideEffect)
	{
	}

	[Token(Token = "0x6009F2B")]
	[Address(RVA = "0x18E99B4", Offset = "0x18E99B4", VA = "0x18E99B4")]
	public void AnimationShow(int showEffect)
	{
	}

	[Token(Token = "0x6009F2C")]
	[Address(RVA = "0x18E9A38", Offset = "0x18E9A38", VA = "0x18E9A38", Slot = "43")]
	public override void UpdateAnimationEvent(bool flag = true, bool effectFlag = true)
	{
	}

	[Token(Token = "0x6009F2D")]
	[Address(RVA = "0x18E9BC0", Offset = "0x18E9BC0", VA = "0x18E9BC0")]
	public new void _003C_003EiFixBaseProxy_InitAvatar(bool P0, bool P1, int P2)
	{
	}

	[Token(Token = "0x6009F2E")]
	[Address(RVA = "0x18E9BE0", Offset = "0x18E9BE0", VA = "0x18E9BE0")]
	public new void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}

	[Token(Token = "0x6009F2F")]
	[Address(RVA = "0x18E9BE8", Offset = "0x18E9BE8", VA = "0x18E9BE8")]
	public void _003C_003EiFixBaseProxy_DoUpdate()
	{
	}

	[Token(Token = "0x6009F30")]
	[Address(RVA = "0x18E9BF0", Offset = "0x18E9BF0", VA = "0x18E9BF0")]
	public void _003C_003EiFixBaseProxy_UpdateAnimationEvent(bool P0, bool P1)
	{
	}
}
