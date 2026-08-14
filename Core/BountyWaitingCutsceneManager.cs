using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000440")]
public class BountyWaitingCutsceneManager : InGameCutsceneManager
{
	[Token(Token = "0x2000441")]
	private sealed class _003CDelayOneFrameChooseAvatar_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4003C1F")]
		[FieldOffset(Offset = "0x8")]
		internal BountyWaitingCutsceneManager _0024this;

		[Token(Token = "0x4003C20")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4003C21")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4003C22")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170001DA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600154A")]
			[Address(RVA = "0x14B4410", Offset = "0x14B4410", VA = "0x14B4410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x14B4418", Offset = "0x14B4418", VA = "0x14B4418", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x14B30AC", Offset = "0x14B30AC", VA = "0x14B30AC")]
		public _003CDelayOneFrameChooseAvatar_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6001549")]
		[Address(RVA = "0x14B432C", Offset = "0x14B432C", VA = "0x14B432C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600154C")]
		[Address(RVA = "0x14B4420", Offset = "0x14B4420", VA = "0x14B4420", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600154D")]
		[Address(RVA = "0x14B4434", Offset = "0x14B4434", VA = "0x14B4434", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4003C19")]
	[FieldOffset(Offset = "0x1C")]
	public RuntimeAnimatorController LocalPlayerAnimController;

	[Token(Token = "0x4003C1A")]
	[FieldOffset(Offset = "0x20")]
	public List<BountyWaitingLocalPlayerCutscene> LocalPlayerCutsceneList;

	[Token(Token = "0x4003C1B")]
	[FieldOffset(Offset = "0x24")]
	public Action OnBuildLocalAvatarFinish;

	[Token(Token = "0x4003C1C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsFemale;

	[Token(Token = "0x4003C1D")]
	[FieldOffset(Offset = "0x2C")]
	private UIMaleAvatar m_LocalPlayerAvatar;

	[Token(Token = "0x4003C1E")]
	[FieldOffset(Offset = "0x30")]
	private BountyCutsceneSwitchWeapon m_SwitchWeaponTool;

	[Token(Token = "0x6001535")]
	[Address(RVA = "0x14B2318", Offset = "0x14B2318", VA = "0x14B2318")]
	public BountyWaitingCutsceneManager()
	{
	}

	[Token(Token = "0x6001536")]
	[Address(RVA = "0x14B23A4", Offset = "0x14B23A4", VA = "0x14B23A4")]
	public new void Awake()
	{
	}

	[Token(Token = "0x6001537")]
	[Address(RVA = "0x14B23AC", Offset = "0x14B23AC", VA = "0x14B23AC")]
	public void OnScenedLoaded()
	{
	}

	[Token(Token = "0x6001538")]
	[Address(RVA = "0x14B2454", Offset = "0x14B2454", VA = "0x14B2454")]
	public void LoadCutsceneAnimPrfeb(int beginIndex, int endIndex)
	{
	}

	[Token(Token = "0x6001539")]
	[Address(RVA = "0x14B2A00", Offset = "0x14B2A00", VA = "0x14B2A00")]
	public void ClearBeforRes(int clearCutsceneIndex)
	{
	}

	[Token(Token = "0x600153A")]
	[Address(RVA = "0x14B2D58", Offset = "0x14B2D58", VA = "0x14B2D58")]
	private void ClearLocalPlayerAvatarAnimclip()
	{
	}

	[Token(Token = "0x600153B")]
	[Address(RVA = "0x14B2F70", Offset = "0x14B2F70", VA = "0x14B2F70", Slot = "6")]
	public override void OnCutsceneFinish(InGameCutscene FinishedCutscene)
	{
	}

	[Token(Token = "0x600153C")]
	[Address(RVA = "0x14B23D0", Offset = "0x14B23D0", VA = "0x14B23D0")]
	private IEnumerator DelayOneFrameChooseAvatar()
	{
		return null;
	}

	[Token(Token = "0x600153D")]
	[Address(RVA = "0x14B30B4", Offset = "0x14B30B4", VA = "0x14B30B4")]
	public void ChooseAvatar()
	{
	}

	[Token(Token = "0x600153E")]
	[Address(RVA = "0x14B30B8", Offset = "0x14B30B8", VA = "0x14B30B8")]
	public void InitLocalPlayerAvatart()
	{
	}

	[Token(Token = "0x600153F")]
	[Address(RVA = "0x14B3744", Offset = "0x14B3744", VA = "0x14B3744")]
	public void OnAvatarUpdateFinish()
	{
	}

	[Token(Token = "0x6001540")]
	[Address(RVA = "0x14B396C", Offset = "0x14B396C", VA = "0x14B396C")]
	public void ShowOrHideCutsceneAvatarHandWeapon(bool isShow)
	{
	}

	[Token(Token = "0x6001541")]
	[Address(RVA = "0x14B3A28", Offset = "0x14B3A28", VA = "0x14B3A28")]
	public void ShowOrHideCutsceneAvatarBackWeapon(bool isShow)
	{
	}

	[Token(Token = "0x6001542")]
	[Address(RVA = "0x14B3AE4", Offset = "0x14B3AE4", VA = "0x14B3AE4")]
	private void HideOrShowPlayer(bool isShow)
	{
	}

	[Token(Token = "0x6001543")]
	[Address(RVA = "0x14B3C10", Offset = "0x14B3C10", VA = "0x14B3C10", Slot = "4")]
	public override bool PlayCutscene(int index, [Optional] Action OnCutsceneFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x6001544")]
	[Address(RVA = "0x14B3FAC", Offset = "0x14B3FAC", VA = "0x14B3FAC")]
	private void PlayCutsceneAnim(Animator animator, AnimationClip clip)
	{
	}

	[Token(Token = "0x6001545")]
	[Address(RVA = "0x14B415C", Offset = "0x14B415C", VA = "0x14B415C", Slot = "5")]
	public override void ProcessCustsceneFinishOrStoped(InGameCutscene FinishedCutscene)
	{
	}

	[Token(Token = "0x6001546")]
	[Address(RVA = "0x14B4250", Offset = "0x14B4250", VA = "0x14B4250")]
	public void HideLocalPlayerAvatar()
	{
	}

	[Token(Token = "0x6001547")]
	[Address(RVA = "0x14B4328", Offset = "0x14B4328", VA = "0x14B4328")]
	private void _003CInitLocalPlayerAvatart_003Em__0(UIStatedAvatar s)
	{
	}
}
