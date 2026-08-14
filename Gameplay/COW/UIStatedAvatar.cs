using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FE2")]
public class UIStatedAvatar : UIAnimedAvatar
{
	[Token(Token = "0x2001FE3")]
	protected class InternalState : UIAvatarStateBase
	{
		[Token(Token = "0x400C887")]
		[FieldOffset(Offset = "0x2D")]
		public bool CurrentStateDirty;

		[Token(Token = "0x400C888")]
		[FieldOffset(Offset = "0x30")]
		public uint LastSelectClothes;

		[Token(Token = "0x400C889")]
		[FieldOffset(Offset = "0x34")]
		public bool LastPlayClothesChangeAnim;

		[Token(Token = "0x400C88A")]
		[FieldOffset(Offset = "0x35")]
		public bool LastPlayClothesIdleAnim;

		[Token(Token = "0x400C88B")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, AvatarWardrobeData> SlotClothes;

		[Token(Token = "0x600A0C2")]
		[Address(RVA = "0x2007A14", Offset = "0x2007A14", VA = "0x2007A14")]
		public InternalState()
		{
		}
	}

	[Token(Token = "0x400C877")]
	[FieldOffset(Offset = "0x174")]
	protected InternalState m_InternalState;

	[Token(Token = "0x400C878")]
	[FieldOffset(Offset = "0x178")]
	protected UIAvatarState m_CurrentState;

	[Token(Token = "0x400C879")]
	[FieldOffset(Offset = "0x17C")]
	protected Transform m_HeadTF;

	[Token(Token = "0x400C87A")]
	[FieldOffset(Offset = "0x180")]
	protected Transform m_HipTF;

	[Token(Token = "0x400C87B")]
	[FieldOffset(Offset = "0x184")]
	protected Transform m_RootTF;

	[Token(Token = "0x400C87C")]
	[FieldOffset(Offset = "0x188")]
	private bool m_IsMatchResult;

	[Token(Token = "0x400C87D")]
	[FieldOffset(Offset = "0x18C")]
	private Dictionary<uint, EventClothEffectsData> m_IdtoLobbyShowClothEffectDic;

	[Token(Token = "0x400C87E")]
	[FieldOffset(Offset = "0x190")]
	private uint m_delayCallIDShow;

	[Token(Token = "0x400C87F")]
	[FieldOffset(Offset = "0x194")]
	private uint m_delayCallIDHide;

	[Token(Token = "0x400C880")]
	[FieldOffset(Offset = "0x198")]
	private uint m_AvatarEffectShowTime;

	[Token(Token = "0x400C881")]
	[FieldOffset(Offset = "0x19C")]
	private uint m_AvatarEffectHideTime;

	[Token(Token = "0x400C882")]
	[FieldOffset(Offset = "0x1A0")]
	private bool m_currentEventEffectsVisibility;

	[Token(Token = "0x400C883")]
	[FieldOffset(Offset = "0x1A1")]
	private bool m_IsShowSpecialIdle;

	[Token(Token = "0x400C884")]
	[FieldOffset(Offset = "0x1A4")]
	protected GameObject m_GoFootHalo;

	[Token(Token = "0x400C885")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C886")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AnimationClip> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17000FCC")]
	protected bool IsMatchResult
	{
		[Token(Token = "0x600A08C")]
		[Address(RVA = "0x2007AA0", Offset = "0x2007AA0", VA = "0x2007AA0")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x600A08D")]
		[Address(RVA = "0x2007AF8", Offset = "0x2007AF8", VA = "0x2007AF8")]
		set
		{
		}
	}

	[Token(Token = "0x600A08B")]
	[Address(RVA = "0x2007934", Offset = "0x2007934", VA = "0x2007934")]
	public UIStatedAvatar()
	{
	}

	[Token(Token = "0x600A08E")]
	[Address(RVA = "0x2007B58", Offset = "0x2007B58", VA = "0x2007B58")]
	public UIAvatarState GetCurrentState()
	{
		return null;
	}

	[Token(Token = "0x600A08F")]
	[Address(RVA = "0x2007C04", Offset = "0x2007C04", VA = "0x2007C04")]
	public void UpdateCollectionID(uint collectionID)
	{
	}

	[Token(Token = "0x600A090")]
	[Address(RVA = "0x2007C7C", Offset = "0x2007C7C", VA = "0x2007C7C")]
	public void ClearInternalState()
	{
	}

	[Token(Token = "0x600A091")]
	[Address(RVA = "0x2007CE4", Offset = "0x2007CE4", VA = "0x2007CE4")]
	public void ResetInternalState()
	{
	}

	[Token(Token = "0x600A092")]
	[Address(RVA = "0x2007D98", Offset = "0x2007D98", VA = "0x2007D98", Slot = "24")]
	public override void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1)
	{
	}

	[Token(Token = "0x600A093")]
	[Address(RVA = "0x2007E64", Offset = "0x2007E64", VA = "0x2007E64", Slot = "26")]
	protected override void CharacterCreatedCallback(UMAData umaData)
	{
	}

	[Token(Token = "0x600A094")]
	[Address(RVA = "0x2008210", Offset = "0x2008210", VA = "0x2008210")]
	public Vector3 GetRightLegWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600A095")]
	[Address(RVA = "0x20082FC", Offset = "0x20082FC", VA = "0x20082FC", Slot = "27")]
	protected override void OnInitAvatarAfterBuild(bool isLocal)
	{
	}

	[Token(Token = "0x600A096")]
	[Address(RVA = "0x20083DC", Offset = "0x20083DC", VA = "0x20083DC", Slot = "28")]
	protected override void CharacterUpdateCallBack(UMAData umaData)
	{
	}

	[Token(Token = "0x600A097")]
	[Address(RVA = "0x200923C", Offset = "0x200923C", VA = "0x200923C", Slot = "42")]
	public override void UpdateAnimator(CSSharedAvatarData aData, bool female)
	{
	}

	[Token(Token = "0x600A098")]
	[Address(RVA = "0x2008910", Offset = "0x2008910", VA = "0x2008910")]
	protected void ProcessClothEffect()
	{
	}

	[Token(Token = "0x600A099")]
	[Address(RVA = "0x2008990", Offset = "0x2008990", VA = "0x2008990")]
	protected void ProcessMaterialAnimEffect()
	{
	}

	[Token(Token = "0x600A09A")]
	[Address(RVA = "0x200AB78", Offset = "0x200AB78", VA = "0x200AB78")]
	public void ChangeLayer(int layer)
	{
	}

	[Token(Token = "0x600A09B")]
	[Address(RVA = "0x200A364", Offset = "0x200A364", VA = "0x200A364")]
	protected void LoadMaterialAnimEffect()
	{
	}

	[Token(Token = "0x600A09C")]
	[Address(RVA = "0x20092EC", Offset = "0x20092EC", VA = "0x20092EC")]
	protected void LoadClothEffect()
	{
	}

	[Token(Token = "0x600A09D")]
	[Address(RVA = "0x200AF40", Offset = "0x200AF40", VA = "0x200AF40")]
	public void ShowLobbyEffectIntervals()
	{
	}

	[Token(Token = "0x600A09E")]
	[Address(RVA = "0x200B01C", Offset = "0x200B01C", VA = "0x200B01C")]
	private void _ShowLobbyEffect()
	{
	}

	[Token(Token = "0x600A09F")]
	[Address(RVA = "0x200B1AC", Offset = "0x200B1AC", VA = "0x200B1AC")]
	private void _HideLobbyEffect()
	{
	}

	[Token(Token = "0x600A0A0")]
	[Address(RVA = "0x200ACB0", Offset = "0x200ACB0", VA = "0x200ACB0")]
	public void ResetLobbyAvatarEffect()
	{
	}

	[Token(Token = "0x600A0A1")]
	[Address(RVA = "0x200B33C", Offset = "0x200B33C", VA = "0x200B33C")]
	public void ResetChangeIdle()
	{
	}

	[Token(Token = "0x600A0A2")]
	[Address(RVA = "0x200B3B0", Offset = "0x200B3B0", VA = "0x200B3B0")]
	public void ResetIdle()
	{
	}

	[Token(Token = "0x600A0A3")]
	[Address(RVA = "0x200AE20", Offset = "0x200AE20", VA = "0x200AE20")]
	private void AddAvatarLobbyEffect(EventClothEffectsData data)
	{
	}

	[Token(Token = "0x600A0A4")]
	[Address(RVA = "0x200B434", Offset = "0x200B434", VA = "0x200B434")]
	public void SetEventEffectsVisibilityIfNeed(bool isVisible)
	{
	}

	[Token(Token = "0x600A0A5")]
	protected void CallbackOnce<T>(ref Action<T> callback, T param)
	{
	}

	[Token(Token = "0x600A0A6")]
	[Address(RVA = "0x200B4E4", Offset = "0x200B4E4", VA = "0x200B4E4", Slot = "38")]
	public override void ResetAvatar()
	{
	}

	[Token(Token = "0x600A0A7")]
	[Address(RVA = "0x2008138", Offset = "0x2008138", VA = "0x2008138")]
	public void UpdateState(UIAvatarState s)
	{
	}

	[Token(Token = "0x600A0A8")]
	[Address(RVA = "0x200B7D4", Offset = "0x200B7D4", VA = "0x200B7D4")]
	protected void PlayAnimOneShotEvt(string animationResID)
	{
	}

	[Token(Token = "0x600A0A9")]
	[Address(RVA = "0x200BA10", Offset = "0x200BA10", VA = "0x200BA10")]
	public void RefreshState()
	{
	}

	[Token(Token = "0x600A0AA")]
	[Address(RVA = "0x200E3FC", Offset = "0x200E3FC", VA = "0x200E3FC")]
	public static void UpdateClothes(uint wId, List<uint> cs)
	{
	}

	[Token(Token = "0x600A0AB")]
	[Address(RVA = "0x200E470", Offset = "0x200E470", VA = "0x200E470")]
	public static void UpdateClothes(AvatarWardrobeData wData, List<uint> cs)
	{
	}

	[Token(Token = "0x600A0AC")]
	[Address(RVA = "0x200E6A8", Offset = "0x200E6A8", VA = "0x200E6A8")]
	public static void UpdateClothes(AvatarWardrobeData wData, UIAvatarState cs, bool removeConflictSlot, bool considerHidingTarget)
	{
	}

	[Token(Token = "0x600A0AD")]
	[Address(RVA = "0x200E8A4", Offset = "0x200E8A4", VA = "0x200E8A4")]
	public static AvatarWardrobeData FindClothesWithAnimOrEffect(IEnumerable<uint> cs)
	{
		return null;
	}

	[Token(Token = "0x600A0AE")]
	[Address(RVA = "0x200EEC8", Offset = "0x200EEC8", VA = "0x200EEC8")]
	public AvatarWardrobeData GetCurrentSlot(string slot)
	{
		return null;
	}

	[Token(Token = "0x600A0AF")]
	[Address(RVA = "0x200B614", Offset = "0x200B614", VA = "0x200B614")]
	protected void CheckAndUpdateState(InternalState dst, UIAvatarState src)
	{
	}

	[Token(Token = "0x600A0B0")]
	[Address(RVA = "0x200BAA8", Offset = "0x200BAA8", VA = "0x200BAA8")]
	protected void UpdateState(InternalState dst, bool faceDirty, bool colorDirty, bool clothesDirty, bool bagDirty, out bool hidingSet, out string hidingSlot)
	{
	}

	[Token(Token = "0x600A0B1")]
	[Address(RVA = "0x200EFC4", Offset = "0x200EFC4", VA = "0x200EFC4")]
	private void CheckAndUpdateFaceClothes(InternalState dst, UIAvatarState src, ref bool faceDirty, ref bool colorDirty, ref bool clothesDirty, ref bool bagDirty)
	{
	}

	[Token(Token = "0x600A0B2")]
	[Address(RVA = "0x200FA3C", Offset = "0x200FA3C", VA = "0x200FA3C")]
	private bool CheckAndUpdateField(ref bool dst, bool src)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0B3")]
	[Address(RVA = "0x200FACC", Offset = "0x200FACC", VA = "0x200FACC")]
	private bool CheckAndUpdateField(ref uint dst, uint src)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0B4")]
	[Address(RVA = "0x200FB5C", Offset = "0x200FB5C", VA = "0x200FB5C")]
	private bool CheckAndUpdateField(ref bool dst, UIAvatarStateTriggerValue<bool> src)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0B5")]
	[Address(RVA = "0x200F950", Offset = "0x200F950", VA = "0x200F950")]
	private bool CheckAndUpdateField(ref uint dst, UIAvatarStateTriggerValue<uint> src)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0B6")]
	[Address(RVA = "0x2008AE0", Offset = "0x2008AE0", VA = "0x2008AE0")]
	public void UpdateLobbyFootHalo()
	{
	}

	[Token(Token = "0x600A0B7")]
	[Address(RVA = "0x200911C", Offset = "0x200911C", VA = "0x200911C")]
	public void ClearFootHalo()
	{
	}

	[Token(Token = "0x600A0B8")]
	[Address(RVA = "0x200FC48", Offset = "0x200FC48", VA = "0x200FC48")]
	private void _003C_ShowLobbyEffect_003Em__0()
	{
	}

	[Token(Token = "0x600A0B9")]
	[Address(RVA = "0x200FD0C", Offset = "0x200FD0C", VA = "0x200FD0C")]
	private void _003C_HideLobbyEffect_003Em__1()
	{
	}

	[Token(Token = "0x600A0BA")]
	[Address(RVA = "0x200FDD0", Offset = "0x200FDD0", VA = "0x200FDD0")]
	private static bool _003CUpdateState_003Em__2(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0BB")]
	[Address(RVA = "0x200FE68", Offset = "0x200FE68", VA = "0x200FE68")]
	private static bool _003CUpdateState_003Em__3(AnimationClip s)
	{
		return default(bool);
	}

	[Token(Token = "0x600A0BC")]
	[Address(RVA = "0x200FF00", Offset = "0x200FF00", VA = "0x200FF00")]
	public new void _003C_003EiFixBaseProxy_InitAvatar(bool P0, bool P1, int P2)
	{
	}

	[Token(Token = "0x600A0BD")]
	[Address(RVA = "0x200FF20", Offset = "0x200FF20", VA = "0x200FF20")]
	public new void _003C_003EiFixBaseProxy_CharacterUpdateCallBack(UMAData P0)
	{
	}

	[Token(Token = "0x600A0BE")]
	[Address(RVA = "0x200FF28", Offset = "0x200FF28", VA = "0x200FF28")]
	public void _003C_003EiFixBaseProxy_CharacterCreatedCallback(UMAData P0)
	{
	}

	[Token(Token = "0x600A0BF")]
	[Address(RVA = "0x200FF30", Offset = "0x200FF30", VA = "0x200FF30")]
	public void _003C_003EiFixBaseProxy_OnInitAvatarAfterBuild(bool P0)
	{
	}

	[Token(Token = "0x600A0C0")]
	[Address(RVA = "0x200FF38", Offset = "0x200FF38", VA = "0x200FF38")]
	public void _003C_003EiFixBaseProxy_UpdateAnimator(CSSharedAvatarData P0, bool P1)
	{
	}

	[Token(Token = "0x600A0C1")]
	[Address(RVA = "0x200FF40", Offset = "0x200FF40", VA = "0x200FF40")]
	public new void _003C_003EiFixBaseProxy_ResetAvatar()
	{
	}
}
