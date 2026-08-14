using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FE6")]
public class UIPetAvatar : Entity
{
	[Token(Token = "0x2001FE7")]
	private sealed class _003CGetActionSound_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C8BB")]
		[FieldOffset(Offset = "0x8")]
		internal PetActionType acition;

		[Token(Token = "0x600A0F6")]
		[Address(RVA = "0x23ECD70", Offset = "0x23ECD70", VA = "0x23ECD70")]
		public _003CGetActionSound_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A0F7")]
		[Address(RVA = "0x23F0458", Offset = "0x23F0458", VA = "0x23F0458")]
		internal bool _003C_003Em__0(PetActionData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001FE8")]
	private sealed class _003CGetActionMoodSound_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C8BC")]
		[FieldOffset(Offset = "0x8")]
		internal PetActionType acition;

		[Token(Token = "0x600A0F8")]
		[Address(RVA = "0x23ECFA0", Offset = "0x23ECFA0", VA = "0x23ECFA0")]
		public _003CGetActionMoodSound_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600A0F9")]
		[Address(RVA = "0x23F0420", Offset = "0x23F0420", VA = "0x23F0420")]
		internal bool _003C_003Em__0(PetActionData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400C89C")]
	[FieldOffset(Offset = "0x34")]
	private uint m_PetID;

	[Token(Token = "0x400C89D")]
	[FieldOffset(Offset = "0x38")]
	private uint m_SkinId;

	[Token(Token = "0x400C89E")]
	[FieldOffset(Offset = "0x3C")]
	private Animation m_animator;

	[Token(Token = "0x400C89F")]
	[FieldOffset(Offset = "0x40")]
	private UIItemInputHandler m_AvatarInput;

	[Token(Token = "0x400C8A0")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider m_boxCollider;

	[Token(Token = "0x400C8A1")]
	[FieldOffset(Offset = "0x48")]
	private bool m_CanClick;

	[Token(Token = "0x400C8A2")]
	[FieldOffset(Offset = "0x4C")]
	private string keep_animation_loop;

	[Token(Token = "0x400C8A3")]
	[FieldOffset(Offset = "0x50")]
	private uint keep_animation_loop_id;

	[Token(Token = "0x400C8A4")]
	[FieldOffset(Offset = "0x54")]
	private bool start_random_play;

	[Token(Token = "0x400C8A5")]
	private const float random_time = 8f;

	[Token(Token = "0x400C8A6")]
	[FieldOffset(Offset = "0x58")]
	private float time_conter;

	[Token(Token = "0x400C8A7")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject Effect_Upgrade;

	[Token(Token = "0x400C8A8")]
	[FieldOffset(Offset = "0x4")]
	private static GameObject Effect_Feed;

	[Token(Token = "0x400C8A9")]
	[FieldOffset(Offset = "0x8")]
	private static GameObject Effect_FeedMore;

	[Token(Token = "0x400C8AA")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject vfx_pet_lobby;

	[Token(Token = "0x400C8AB")]
	[FieldOffset(Offset = "0x60")]
	private GameObject vfx_petfood;

	[Token(Token = "0x400C8AC")]
	[FieldOffset(Offset = "0x64")]
	private GameObject vfx_petfood_multi;

	[Token(Token = "0x400C8AD")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<string, List<GameObject>> effect_dic;

	[Token(Token = "0x400C8AE")]
	[FieldOffset(Offset = "0x6C")]
	private FeedType food_action_flag;

	[Token(Token = "0x400C8AF")]
	[FieldOffset(Offset = "0x70")]
	private string current_action;

	[Token(Token = "0x400C8B0")]
	[FieldOffset(Offset = "0x74")]
	public Action<bool> IsEmoteChange;

	[Token(Token = "0x400C8B1")]
	[FieldOffset(Offset = "0x78")]
	private bool m_PlayPetLoopIdleSound;

	[Token(Token = "0x400C8B2")]
	[FieldOffset(Offset = "0x7C")]
	private AudioResource IdleAudioRes;

	[Token(Token = "0x400C8B3")]
	[FieldOffset(Offset = "0x80")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x400C8B4")]
	[FieldOffset(Offset = "0x84")]
	private bool m_FingerDownOnPet;

	[Token(Token = "0x400C8B5")]
	[FieldOffset(Offset = "0x88")]
	private float OffsetX;

	[Token(Token = "0x400C8B6")]
	[FieldOffset(Offset = "0x8C")]
	private float OffsetY;

	[Token(Token = "0x400C8B7")]
	[FieldOffset(Offset = "0x90")]
	private bool m_PlayLoopIdle;

	[Token(Token = "0x400C8B8")]
	[FieldOffset(Offset = "0x94")]
	private float m_LoopIdleCount;

	[Token(Token = "0x400C8B9")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 pressPos;

	[Token(Token = "0x400C8BA")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 releasePos;

	[Token(Token = "0x600A0C3")]
	[Address(RVA = "0x23E702C", Offset = "0x23E702C", VA = "0x23E702C")]
	public UIPetAvatar()
	{
	}

	[Token(Token = "0x600A0C4")]
	[Address(RVA = "0x23E70EC", Offset = "0x23E70EC", VA = "0x23E70EC")]
	public static UIPetAvatar CreateAvatar(uint pet_id, uint skin_Id = 0u, [Optional] FrontEndPreviewComponent frontEndPreviewComponent, bool playPetLoopIdleSound = false)
	{
		return null;
	}

	[Token(Token = "0x600A0C5")]
	[Address(RVA = "0x23E7AB0", Offset = "0x23E7AB0", VA = "0x23E7AB0")]
	public static UIPetAvatar CreateAvatarWithPlanarShadow(uint pet_id, uint skin_Id = 0u, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return null;
	}

	[Token(Token = "0x600A0C6")]
	[Address(RVA = "0x23E7C58", Offset = "0x23E7C58", VA = "0x23E7C58")]
	public BoxCollider GetPetCollider()
	{
		return null;
	}

	[Token(Token = "0x600A0C7")]
	[Address(RVA = "0x23E7CB0", Offset = "0x23E7CB0", VA = "0x23E7CB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600A0C8")]
	[Address(RVA = "0x23E7730", Offset = "0x23E7730", VA = "0x23E7730")]
	private static void InitPetAnimClip(UIPetAvatar pet_avatar)
	{
	}

	[Token(Token = "0x600A0C9")]
	[Address(RVA = "0x23E7D98", Offset = "0x23E7D98", VA = "0x23E7D98")]
	public uint GetPetID()
	{
		return default(uint);
	}

	[Token(Token = "0x600A0CA")]
	[Address(RVA = "0x23E7DF0", Offset = "0x23E7DF0", VA = "0x23E7DF0")]
	public uint GetPetSkinId()
	{
		return default(uint);
	}

	[Token(Token = "0x600A0CB")]
	[Address(RVA = "0x23E7E48", Offset = "0x23E7E48", VA = "0x23E7E48")]
	public void SetLobbyEffect(Vector3 position)
	{
	}

	[Token(Token = "0x600A0CC")]
	[Address(RVA = "0x23E8448", Offset = "0x23E8448", VA = "0x23E8448")]
	private void UnLoadLobbyEffect()
	{
	}

	[Token(Token = "0x600A0CD")]
	[Address(RVA = "0x23E8560", Offset = "0x23E8560", VA = "0x23E8560")]
	public static UIPetAvatar TryCreatePetSkinAvatar(uint skin_id)
	{
		return null;
	}

	[Token(Token = "0x600A0CE")]
	[Address(RVA = "0x23E8DE0", Offset = "0x23E8DE0", VA = "0x23E8DE0")]
	public static UIPetAvatar TryCreatePetSkinAvatarWithPlanarShadow(uint skin_id)
	{
		return null;
	}

	[Token(Token = "0x600A0CF")]
	[Address(RVA = "0x23E8704", Offset = "0x23E8704", VA = "0x23E8704")]
	public static UIPetAvatar CreateSkinAvatar(uint skin_id, [Optional] FrontEndPreviewComponent frontEndPreviewComponent, bool playPetLoopIdleSound = false)
	{
		return null;
	}

	[Token(Token = "0x600A0D0")]
	[Address(RVA = "0x23E8F7C", Offset = "0x23E8F7C", VA = "0x23E8F7C")]
	public static UIPetAvatar CreateSkinAvatarWithPlanarShadow(uint skin_id, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return null;
	}

	[Token(Token = "0x600A0D1")]
	[Address(RVA = "0x23E9108", Offset = "0x23E9108", VA = "0x23E9108")]
	public void SetInputEnable(bool inputEnable)
	{
	}

	[Token(Token = "0x600A0D2")]
	[Address(RVA = "0x23E9204", Offset = "0x23E9204", VA = "0x23E9204")]
	public void SetClickenabled(bool enabled)
	{
	}

	[Token(Token = "0x600A0D3")]
	[Address(RVA = "0x23E9264", Offset = "0x23E9264", VA = "0x23E9264")]
	public void SetBoxColiderenabled()
	{
	}

	[Token(Token = "0x600A0D4")]
	[Address(RVA = "0x23E9364", Offset = "0x23E9364", VA = "0x23E9364")]
	public void SetCastShadow(bool castShadow, EFrontendPlannarShadowType ePlannarShadowType = EFrontendPlannarShadowType.Main)
	{
	}

	[Token(Token = "0x600A0D5")]
	[Address(RVA = "0x23E9618", Offset = "0x23E9618", VA = "0x23E9618")]
	private void Update()
	{
	}

	[Token(Token = "0x600A0D6")]
	[Address(RVA = "0x23EAADC", Offset = "0x23EAADC", VA = "0x23EAADC")]
	private void CheckPlayIdleSound()
	{
	}

	[Token(Token = "0x600A0D7")]
	[Address(RVA = "0x23E96A4", Offset = "0x23E96A4", VA = "0x23E96A4")]
	private void CheckPetOnClick()
	{
	}

	[Token(Token = "0x600A0D8")]
	[Address(RVA = "0x23E9E28", Offset = "0x23E9E28", VA = "0x23E9E28")]
	private void CheckInputButtonDown()
	{
	}

	[Token(Token = "0x600A0D9")]
	[Address(RVA = "0x23EADB4", Offset = "0x23EADB4", VA = "0x23EADB4")]
	private void DoPetLobbyClick(Ray ray)
	{
	}

	[Token(Token = "0x600A0DA")]
	[Address(RVA = "0x23EB3E0", Offset = "0x23EB3E0", VA = "0x23EB3E0")]
	private void DoPetViewClick(Ray ray)
	{
	}

	[Token(Token = "0x600A0DB")]
	[Address(RVA = "0x23EA4CC", Offset = "0x23EA4CC", VA = "0x23EA4CC")]
	private void CheckAnimationPlayState()
	{
	}

	[Token(Token = "0x600A0DC")]
	[Address(RVA = "0x23EA420", Offset = "0x23EA420", VA = "0x23EA420")]
	private void CheckNeedRandomPlayAction(float time)
	{
	}

	[Token(Token = "0x600A0DD")]
	[Address(RVA = "0x23EC6A8", Offset = "0x23EC6A8", VA = "0x23EC6A8")]
	private uint GetRandomNameInLevelUnlock()
	{
		return default(uint);
	}

	[Token(Token = "0x600A0DE")]
	[Address(RVA = "0x23EC700", Offset = "0x23EC700", VA = "0x23EC700")]
	private string GetActionNameByType(PetActionType acition)
	{
		return null;
	}

	[Token(Token = "0x600A0DF")]
	[Address(RVA = "0x23EC8C0", Offset = "0x23EC8C0", VA = "0x23EC8C0")]
	private string GetActionNameByID(int action_id)
	{
		return null;
	}

	[Token(Token = "0x600A0E0")]
	[Address(RVA = "0x23ECA64", Offset = "0x23ECA64", VA = "0x23ECA64")]
	private ResourceID GetActionSound(PetActionType acition)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A0E1")]
	[Address(RVA = "0x23ECD78", Offset = "0x23ECD78", VA = "0x23ECD78")]
	private ResourceID GetActionMoodSound(PetActionType acition)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A0E2")]
	[Address(RVA = "0x23ECFA8", Offset = "0x23ECFA8", VA = "0x23ECFA8")]
	public void PlayAnimationRandom()
	{
	}

	[Token(Token = "0x600A0E3")]
	[Address(RVA = "0x23ED67C", Offset = "0x23ED67C", VA = "0x23ED67C")]
	public void StopAnimationPlay()
	{
	}

	[Token(Token = "0x600A0E4")]
	[Address(RVA = "0x23ED018", Offset = "0x23ED018", VA = "0x23ED018")]
	public void PlayAnimation(PetActionType action, bool loop = false)
	{
	}

	[Token(Token = "0x600A0E5")]
	[Address(RVA = "0x23ED6D8", Offset = "0x23ED6D8", VA = "0x23ED6D8")]
	private void GetFoodVFXAnimation(bool is_multi)
	{
	}

	[Token(Token = "0x600A0E6")]
	[Address(RVA = "0x23EB790", Offset = "0x23EB790", VA = "0x23EB790")]
	public bool CheckPetActionReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600A0E7")]
	[Address(RVA = "0x23EC2D4", Offset = "0x23EC2D4", VA = "0x23EC2D4")]
	public void PlayAnimation(uint id, bool loop = false)
	{
	}

	[Token(Token = "0x600A0E8")]
	[Address(RVA = "0x23EEC74", Offset = "0x23EEC74", VA = "0x23EEC74")]
	private void PlayAnimation(PetActionData data)
	{
	}

	[Token(Token = "0x600A0E9")]
	[Address(RVA = "0x23EDE40", Offset = "0x23EDE40", VA = "0x23EDE40")]
	private void PlayAnimation(string actionName, PetActionType actionType)
	{
	}

	[Token(Token = "0x600A0EA")]
	[Address(RVA = "0x23EBA74", Offset = "0x23EBA74", VA = "0x23EBA74")]
	public void PlayAnimationWithSound(PetActionData data)
	{
	}

	[Token(Token = "0x600A0EB")]
	[Address(RVA = "0x23EE580", Offset = "0x23EE580", VA = "0x23EE580")]
	private void SetActionVFX(PetActionData data)
	{
	}

	[Token(Token = "0x600A0EC")]
	[Address(RVA = "0x23EF58C", Offset = "0x23EF58C", VA = "0x23EF58C")]
	public static void SetPetEffect(Vector3 position)
	{
	}

	[Token(Token = "0x600A0ED")]
	[Address(RVA = "0x23EEF8C", Offset = "0x23EEF8C", VA = "0x23EEF8C")]
	private void ProcessBoneNameRefs(List<GameObject> effect_list)
	{
	}

	[Token(Token = "0x600A0EE")]
	[Address(RVA = "0x23EFC60", Offset = "0x23EFC60", VA = "0x23EFC60")]
	private bool ScaleInLocalSpace(GameObject o)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0EF")]
	[Address(RVA = "0x23EFE08", Offset = "0x23EFE08", VA = "0x23EFE08")]
	public static void UnLoadPetEffect()
	{
	}

	[Token(Token = "0x600A0F0")]
	[Address(RVA = "0x23F00C8", Offset = "0x23F00C8", VA = "0x23F00C8")]
	public static void ShowUpgradeEffect()
	{
	}

	[Token(Token = "0x600A0F1")]
	[Address(RVA = "0x23EBF1C", Offset = "0x23EBF1C", VA = "0x23EBF1C")]
	private static void ShowFeedEffect()
	{
	}

	[Token(Token = "0x600A0F2")]
	[Address(RVA = "0x23EC0F8", Offset = "0x23EC0F8", VA = "0x23EC0F8")]
	private static void ShowFeedMoreEffect()
	{
	}

	[Token(Token = "0x600A0F3")]
	[Address(RVA = "0x23F02A4", Offset = "0x23F02A4", VA = "0x23F02A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600A0F4")]
	[Address(RVA = "0x23F0320", Offset = "0x23F0320", VA = "0x23F0320")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600A0F5")]
	[Address(RVA = "0x23EC63C", Offset = "0x23EC63C", VA = "0x23EC63C")]
	private void ResetLoopIdleState(bool loopState)
	{
	}
}
