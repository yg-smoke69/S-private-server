using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AC2")]
public class BaseTask : MonoBehaviour
{
	[Token(Token = "0x2003AC3")]
	public delegate void CompleteCallBack();

	[Token(Token = "0x2003AC4")]
	private sealed class _003CSuccessCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4018F8F")]
		[FieldOffset(Offset = "0x8")]
		internal BaseTask _0024this;

		[Token(Token = "0x4018F90")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4018F91")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4018F92")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170016EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017455")]
			[Address(RVA = "0x2E67454", Offset = "0x2E67454", VA = "0x2E67454", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017456")]
			[Address(RVA = "0x2E6745C", Offset = "0x2E6745C", VA = "0x2E6745C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017453")]
		[Address(RVA = "0x2E6661C", Offset = "0x2E6661C", VA = "0x2E6661C")]
		public _003CSuccessCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6017454")]
		[Address(RVA = "0x2E67348", Offset = "0x2E67348", VA = "0x2E67348", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017457")]
		[Address(RVA = "0x2E67464", Offset = "0x2E67464", VA = "0x2E67464", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017458")]
		[Address(RVA = "0x2E67478", Offset = "0x2E67478", VA = "0x2E67478", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003AC5")]
	private sealed class _003CFailureCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4018F93")]
		[FieldOffset(Offset = "0x8")]
		internal BaseTask _0024this;

		[Token(Token = "0x4018F94")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4018F95")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4018F96")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170016ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601745B")]
			[Address(RVA = "0x2E6729C", Offset = "0x2E6729C", VA = "0x2E6729C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601745C")]
			[Address(RVA = "0x2E672A4", Offset = "0x2E672A4", VA = "0x2E672A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017459")]
		[Address(RVA = "0x2E66B84", Offset = "0x2E66B84", VA = "0x2E66B84")]
		public _003CFailureCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601745A")]
		[Address(RVA = "0x2E67190", Offset = "0x2E67190", VA = "0x2E67190", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601745D")]
		[Address(RVA = "0x2E672AC", Offset = "0x2E672AC", VA = "0x2E672AC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601745E")]
		[Address(RVA = "0x2E672C0", Offset = "0x2E672C0", VA = "0x2E672C0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4018F80")]
	[FieldOffset(Offset = "0xC")]
	public GameObject SuccessObj;

	[Token(Token = "0x4018F81")]
	[FieldOffset(Offset = "0x10")]
	public GameObject FailureObj;

	[Token(Token = "0x4018F82")]
	[FieldOffset(Offset = "0x14")]
	public Animation[] animations;

	[Token(Token = "0x4018F83")]
	[FieldOffset(Offset = "0x18")]
	public float SuccessShowTime;

	[Token(Token = "0x4018F84")]
	[FieldOffset(Offset = "0x1C")]
	public float FailureShowTime;

	[Token(Token = "0x4018F85")]
	[FieldOffset(Offset = "0x20")]
	public string successSound;

	[Token(Token = "0x4018F86")]
	[FieldOffset(Offset = "0x24")]
	public string FailSound;

	[Token(Token = "0x4018F87")]
	[FieldOffset(Offset = "0x28")]
	public string loopSound;

	[Token(Token = "0x4018F88")]
	[FieldOffset(Offset = "0x2C")]
	private CompleteCallBack callBack;

	[Token(Token = "0x4018F89")]
	[FieldOffset(Offset = "0x30")]
	private CompleteCallBack postCallBack;

	[Token(Token = "0x4018F8A")]
	[FieldOffset(Offset = "0x34")]
	private ResourceID m_resSuccessSound;

	[Token(Token = "0x4018F8B")]
	[FieldOffset(Offset = "0x38")]
	private ResourceID m_resFailSound;

	[Token(Token = "0x4018F8C")]
	[FieldOffset(Offset = "0x3C")]
	private ResourceID m_loopSound;

	[Token(Token = "0x4018F8D")]
	[FieldOffset(Offset = "0x40")]
	private AudioResource m_loopAudio;

	[Token(Token = "0x4018F8E")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsShowedSuccess;

	[Token(Token = "0x601743D")]
	[Address(RVA = "0x2E65FC4", Offset = "0x2E65FC4", VA = "0x2E65FC4")]
	public BaseTask()
	{
	}

	[Token(Token = "0x601743E")]
	[Address(RVA = "0x2E6607C", Offset = "0x2E6607C", VA = "0x2E6607C", Slot = "4")]
	public virtual void OnStart()
	{
	}

	[Token(Token = "0x601743F")]
	[Address(RVA = "0x2E66394", Offset = "0x2E66394", VA = "0x2E66394")]
	public void ShowSuccess()
	{
	}

	[Token(Token = "0x6017440")]
	[Address(RVA = "0x2E66550", Offset = "0x2E66550", VA = "0x2E66550")]
	private IEnumerator SuccessCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6017441")]
	[Address(RVA = "0x2E66624", Offset = "0x2E66624", VA = "0x2E66624")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6017442")]
	[Address(RVA = "0x2E6669C", Offset = "0x2E6669C", VA = "0x2E6669C", Slot = "5")]
	public virtual void OnSuccess()
	{
	}

	[Token(Token = "0x6017443")]
	[Address(RVA = "0x2E66918", Offset = "0x2E66918", VA = "0x2E66918")]
	public void ShowFailure()
	{
	}

	[Token(Token = "0x6017444")]
	[Address(RVA = "0x2E66AB8", Offset = "0x2E66AB8", VA = "0x2E66AB8")]
	private IEnumerator FailureCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6017445")]
	[Address(RVA = "0x2E66B8C", Offset = "0x2E66B8C", VA = "0x2E66B8C", Slot = "6")]
	public virtual void OnFailure()
	{
	}

	[Token(Token = "0x6017446")]
	[Address(RVA = "0x2E66BE0", Offset = "0x2E66BE0", VA = "0x2E66BE0")]
	public void SetCompleteCallBack(CompleteCallBack value, CompleteCallBack post)
	{
	}

	[Token(Token = "0x6017447")]
	[Address(RVA = "0x2E66C60", Offset = "0x2E66C60", VA = "0x2E66C60", Slot = "7")]
	public virtual void OnPostSuccess()
	{
	}

	[Token(Token = "0x6017448")]
	[Address(RVA = "0x2E66CCC", Offset = "0x2E66CCC", VA = "0x2E66CCC")]
	protected void PlayAnimation()
	{
	}

	[Token(Token = "0x6017449")]
	[Address(RVA = "0x2E66D8C", Offset = "0x2E66D8C", VA = "0x2E66D8C")]
	protected void StopAnimation()
	{
	}

	[Token(Token = "0x601744A")]
	[Address(RVA = "0x2E66E4C", Offset = "0x2E66E4C", VA = "0x2E66E4C")]
	protected void PlayLoopSound()
	{
	}

	[Token(Token = "0x601744B")]
	[Address(RVA = "0x2E66F68", Offset = "0x2E66F68", VA = "0x2E66F68")]
	protected void StopLoopSound()
	{
	}

	[Token(Token = "0x601744C")]
	[Address(RVA = "0x2E67088", Offset = "0x2E67088", VA = "0x2E67088", Slot = "8")]
	public virtual void Pause()
	{
	}

	[Token(Token = "0x601744D")]
	[Address(RVA = "0x2E670DC", Offset = "0x2E670DC", VA = "0x2E670DC", Slot = "9")]
	public virtual void Resume()
	{
	}

	[Token(Token = "0x601744E")]
	[Address(RVA = "0x2E67130", Offset = "0x2E67130", VA = "0x2E67130")]
	private void OnDestroy()
	{
	}
}
