using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000679")]
public class LevelPhotograph : MonoBehaviour
{
	[Token(Token = "0x200067A")]
	private sealed class _003CShowEffect_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400480E")]
		[FieldOffset(Offset = "0x8")]
		internal LevelPhotograph _0024this;

		[Token(Token = "0x400480F")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4004810")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4004811")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000332")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600297F")]
			[Address(RVA = "0x3115EF0", Offset = "0x3115EF0", VA = "0x3115EF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000333")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002980")]
			[Address(RVA = "0x3115EF8", Offset = "0x3115EF8", VA = "0x3115EF8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600297D")]
		[Address(RVA = "0x31157D4", Offset = "0x31157D4", VA = "0x31157D4")]
		public _003CShowEffect_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600297E")]
		[Address(RVA = "0x3115D58", Offset = "0x3115D58", VA = "0x3115D58", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002981")]
		[Address(RVA = "0x3115F00", Offset = "0x3115F00", VA = "0x3115F00", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002982")]
		[Address(RVA = "0x3115F14", Offset = "0x3115F14", VA = "0x3115F14", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40047FB")]
	[FieldOffset(Offset = "0xC")]
	public float moveSpeedScale;

	[Token(Token = "0x40047FC")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 XMoveRange;

	[Token(Token = "0x40047FD")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 YMoveRange;

	[Token(Token = "0x40047FE")]
	[FieldOffset(Offset = "0x20")]
	public float MAX_FOV;

	[Token(Token = "0x40047FF")]
	[FieldOffset(Offset = "0x24")]
	public float MIN_FOV;

	[Token(Token = "0x4004800")]
	[FieldOffset(Offset = "0x28")]
	public string EventLogClickType;

	[Token(Token = "0x4004801")]
	[FieldOffset(Offset = "0x2C")]
	public string SoundId;

	[Token(Token = "0x4004802")]
	[FieldOffset(Offset = "0x30")]
	public string EffectId;

	[Token(Token = "0x4004803")]
	[FieldOffset(Offset = "0x34")]
	public Transform EffectObject;

	[Token(Token = "0x4004804")]
	[FieldOffset(Offset = "0x38")]
	public float EffectShowTime;

	[Token(Token = "0x4004805")]
	[FieldOffset(Offset = "0x3C")]
	public bool IsCoverDefaultSound;

	[Token(Token = "0x4004806")]
	[FieldOffset(Offset = "0x40")]
	private Camera PhotoCamera;

	[Token(Token = "0x4004807")]
	[FieldOffset(Offset = "0x44")]
	private float m_OrgFOV;

	[Token(Token = "0x4004808")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsPlayerInTrigger;

	[Token(Token = "0x4004809")]
	[FieldOffset(Offset = "0x4C")]
	public ResourceID SoundResId;

	[Token(Token = "0x400480A")]
	[FieldOffset(Offset = "0x50")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400480B")]
	[FieldOffset(Offset = "0x54")]
	public float BanTriggerMatchTime;

	[Token(Token = "0x400480C")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsTraingMode;

	[Token(Token = "0x400480D")]
	[FieldOffset(Offset = "0x59")]
	private bool m_IsInPhotogragphMode;

	[Token(Token = "0x17000330")]
	public bool IsPlayerInTrigger
	{
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x3113894", Offset = "0x3113894", VA = "0x3113894")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000331")]
	public bool IsInPhotographMode
	{
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x311389C", Offset = "0x311389C", VA = "0x311389C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600296C")]
	[Address(RVA = "0x3113780", Offset = "0x3113780", VA = "0x3113780")]
	public LevelPhotograph()
	{
	}

	[Token(Token = "0x600296F")]
	[Address(RVA = "0x31138A4", Offset = "0x31138A4", VA = "0x31138A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002970")]
	[Address(RVA = "0x3113C68", Offset = "0x3113C68", VA = "0x3113C68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002971")]
	[Address(RVA = "0x3113E8C", Offset = "0x3113E8C", VA = "0x3113E8C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002972")]
	[Address(RVA = "0x31140E4", Offset = "0x31140E4", VA = "0x31140E4")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002973")]
	[Address(RVA = "0x31143AC", Offset = "0x31143AC", VA = "0x31143AC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002974")]
	[Address(RVA = "0x3114300", Offset = "0x3114300", VA = "0x3114300")]
	private void OnPlayerExit()
	{
	}

	[Token(Token = "0x6002975")]
	[Address(RVA = "0x3114524", Offset = "0x3114524", VA = "0x3114524")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x6002976")]
	[Address(RVA = "0x31146C8", Offset = "0x31146C8", VA = "0x31146C8")]
	private void EnterPhotographMode(object[] data)
	{
	}

	[Token(Token = "0x6002977")]
	[Address(RVA = "0x3114C94", Offset = "0x3114C94", VA = "0x3114C94")]
	private void ExitPhotographMode(object[] data)
	{
	}

	[Token(Token = "0x6002978")]
	[Address(RVA = "0x3115270", Offset = "0x3115270", VA = "0x3115270")]
	public void TakePhoto()
	{
	}

	[Token(Token = "0x6002979")]
	[Address(RVA = "0x3115750", Offset = "0x3115750", VA = "0x3115750")]
	private IEnumerator ShowEffect()
	{
		return null;
	}

	[Token(Token = "0x600297A")]
	[Address(RVA = "0x31157DC", Offset = "0x31157DC", VA = "0x31157DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600297B")]
	[Address(RVA = "0x3115C74", Offset = "0x3115C74", VA = "0x3115C74")]
	private void AdjustCameraFOV(object[] data)
	{
	}

	[Token(Token = "0x600297C")]
	[Address(RVA = "0x3115B68", Offset = "0x3115B68", VA = "0x3115B68")]
	private UserControlAxisData GetAxisData(int axisIndex)
	{
		return null;
	}
}
