using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D82")]
public class TimeLineAnimCGEvt : PreviewBaseComponent
{
	[Token(Token = "0x2002D83")]
	private sealed class _003CDelayOneShot_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4011761")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID voiceid;

		[Token(Token = "0x4011762")]
		[FieldOffset(Offset = "0xC")]
		internal TimeLineAnimCGEvt _0024this;

		[Token(Token = "0x4011763")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4011764")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4011765")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001385")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60130D9")]
			[Address(RVA = "0x2639458", Offset = "0x2639458", VA = "0x2639458", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001386")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60130DA")]
			[Address(RVA = "0x2639460", Offset = "0x2639460", VA = "0x2639460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60130D7")]
		[Address(RVA = "0x2638F08", Offset = "0x2638F08", VA = "0x2638F08")]
		public _003CDelayOneShot_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60130D8")]
		[Address(RVA = "0x26390E8", Offset = "0x26390E8", VA = "0x26390E8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60130DB")]
		[Address(RVA = "0x2639468", Offset = "0x2639468", VA = "0x2639468", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60130DC")]
		[Address(RVA = "0x263947C", Offset = "0x263947C", VA = "0x263947C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401175D")]
	[FieldOffset(Offset = "0x10")]
	private Coroutine m_AudioDelayCoroutine;

	[Token(Token = "0x401175E")]
	[FieldOffset(Offset = "0x14")]
	private int m_InsertMusicTicket;

	[Token(Token = "0x401175F")]
	[FieldOffset(Offset = "0x18")]
	public bool IsGachaFeature;

	[Token(Token = "0x4011760")]
	[FieldOffset(Offset = "0x1C")]
	public EAnimAudioBusType AudioBus;

	[Token(Token = "0x60130BE")]
	[Address(RVA = "0x263754C", Offset = "0x263754C", VA = "0x263754C")]
	public TimeLineAnimCGEvt()
	{
	}

	[Token(Token = "0x60130BF")]
	[Address(RVA = "0x263755C", Offset = "0x263755C", VA = "0x263755C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60130C0")]
	[Address(RVA = "0x26376A4", Offset = "0x26376A4", VA = "0x26376A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60130C1")]
	[Address(RVA = "0x26377EC", Offset = "0x26377EC", VA = "0x26377EC")]
	public void AnimCGFinish()
	{
	}

	[Token(Token = "0x60130C2")]
	[Address(RVA = "0x26378AC", Offset = "0x26378AC", VA = "0x26378AC")]
	public void SubtitlePlay(string animEvtName)
	{
	}

	[Token(Token = "0x60130C3")]
	[Address(RVA = "0x26379D0", Offset = "0x26379D0", VA = "0x26379D0")]
	public void SubtitleFinish()
	{
	}

	[Token(Token = "0x60130C4")]
	[Address(RVA = "0x2637A90", Offset = "0x2637A90", VA = "0x2637A90")]
	public void WeaponCGFinish()
	{
	}

	[Token(Token = "0x60130C5")]
	[Address(RVA = "0x2637BF4", Offset = "0x2637BF4", VA = "0x2637BF4")]
	public void WeaponCgStart()
	{
	}

	[Token(Token = "0x60130C6")]
	[Address(RVA = "0x2637D44", Offset = "0x2637D44", VA = "0x2637D44")]
	public void DisableWeaponRotate()
	{
	}

	[Token(Token = "0x60130C7")]
	[Address(RVA = "0x2637FB0", Offset = "0x2637FB0", VA = "0x2637FB0")]
	public void EnableWeaponRotate()
	{
	}

	[Token(Token = "0x60130C8")]
	[Address(RVA = "0x2637D4C", Offset = "0x2637D4C", VA = "0x2637D4C")]
	public void SetWeaponRotateState(bool flag)
	{
	}

	[Token(Token = "0x60130C9")]
	[Address(RVA = "0x2637FB8", Offset = "0x2637FB8", VA = "0x2637FB8")]
	public void SetSpeicalWeaponRotate()
	{
	}

	[Token(Token = "0x60130CA")]
	[Address(RVA = "0x2637FE4", Offset = "0x2637FE4", VA = "0x2637FE4")]
	public void AnimationOver()
	{
	}

	[Token(Token = "0x60130CB")]
	[Address(RVA = "0x26380A4", Offset = "0x26380A4", VA = "0x26380A4")]
	public void SetAnimRotateEnable()
	{
	}

	[Token(Token = "0x60130CC")]
	[Address(RVA = "0x26380BC", Offset = "0x26380BC", VA = "0x26380BC")]
	public void EnableAvatarInputHandler()
	{
	}

	[Token(Token = "0x60130CD")]
	[Address(RVA = "0x2638184", Offset = "0x2638184", VA = "0x2638184")]
	public void PlayVfxEffect(string vfxid)
	{
	}

	[Token(Token = "0x60130CE")]
	[Address(RVA = "0x2638488", Offset = "0x2638488", VA = "0x2638488")]
	public void LoopFrameAndDisableSync()
	{
	}

	[Token(Token = "0x60130CF")]
	[Address(RVA = "0x26385A0", Offset = "0x26385A0", VA = "0x26385A0")]
	public void JumpToFrame(float time)
	{
	}

	[Token(Token = "0x60130D0")]
	[Address(RVA = "0x26386D4", Offset = "0x26386D4", VA = "0x26386D4")]
	public void JumpToFrameAll(float time)
	{
	}

	[Token(Token = "0x60130D1")]
	[Address(RVA = "0x263887C", Offset = "0x263887C", VA = "0x263887C")]
	public void PlayAnimAudioBackGroundEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x60130D2")]
	[Address(RVA = "0x2638A98", Offset = "0x2638A98", VA = "0x2638A98")]
	public void PlayAnimAudioLoopBackGroundEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x60130D3")]
	[Address(RVA = "0x2638CB0", Offset = "0x2638CB0", VA = "0x2638CB0")]
	public void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x60130D4")]
	[Address(RVA = "0x2638E68", Offset = "0x2638E68", VA = "0x2638E68")]
	private IEnumerator DelayOneShot(ResourceID voiceid)
	{
		return null;
	}

	[Token(Token = "0x60130D5")]
	[Address(RVA = "0x2638F10", Offset = "0x2638F10", VA = "0x2638F10")]
	public void ResumeAudioVolume()
	{
	}

	[Token(Token = "0x60130D6")]
	[Address(RVA = "0x2638FE8", Offset = "0x2638FE8", VA = "0x2638FE8")]
	public void ReduceAudioVolume(float volumerate)
	{
	}
}
