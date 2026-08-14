using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0D")]
public class BountySwitchSceneSubtitleController : MonoBehaviour
{
	[Token(Token = "0x2000B0E")]
	private sealed class _003CCoTypeLabel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005F7A")]
		[FieldOffset(Offset = "0x8")]
		internal UILabel label;

		[Token(Token = "0x4005F7B")]
		[FieldOffset(Offset = "0xC")]
		internal string str;

		[Token(Token = "0x4005F7C")]
		[FieldOffset(Offset = "0x10")]
		internal char[] _0024locvar0;

		[Token(Token = "0x4005F7D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024locvar1;

		[Token(Token = "0x4005F7E")]
		[FieldOffset(Offset = "0x18")]
		internal char _003Cletter_003E__1;

		[Token(Token = "0x4005F7F")]
		[FieldOffset(Offset = "0x1C")]
		internal BountySwitchSceneSubtitleController _0024this;

		[Token(Token = "0x4005F80")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4005F81")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4005F82")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x170006D6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60054F1")]
			[Address(RVA = "0x2ED8A4C", Offset = "0x2ED8A4C", VA = "0x2ED8A4C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60054F2")]
			[Address(RVA = "0x2ED8A54", Offset = "0x2ED8A54", VA = "0x2ED8A54", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054EF")]
		[Address(RVA = "0x2ED8470", Offset = "0x2ED8470", VA = "0x2ED8470")]
		public _003CCoTypeLabel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60054F0")]
		[Address(RVA = "0x2ED871C", Offset = "0x2ED871C", VA = "0x2ED871C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x2ED8A5C", Offset = "0x2ED8A5C", VA = "0x2ED8A5C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x2ED8A70", Offset = "0x2ED8A70", VA = "0x2ED8A70", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000B0F")]
	private sealed class _003CPointAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005F83")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CshowPoint_003E__1;

		[Token(Token = "0x4005F84")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CpointCount_003E__1;

		[Token(Token = "0x4005F85")]
		[FieldOffset(Offset = "0x10")]
		internal BountySwitchSceneSubtitleController _0024this;

		[Token(Token = "0x4005F86")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4005F87")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x4005F88")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x170006D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60054F7")]
			[Address(RVA = "0x2ED8D18", Offset = "0x2ED8D18", VA = "0x2ED8D18", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60054F8")]
			[Address(RVA = "0x2ED8D20", Offset = "0x2ED8D20", VA = "0x2ED8D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054F5")]
		[Address(RVA = "0x2ED8714", Offset = "0x2ED8714", VA = "0x2ED8714")]
		public _003CPointAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x2ED8AF8", Offset = "0x2ED8AF8", VA = "0x2ED8AF8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x2ED8D28", Offset = "0x2ED8D28", VA = "0x2ED8D28", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x2ED8D3C", Offset = "0x2ED8D3C", VA = "0x2ED8D3C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005F6A")]
	[FieldOffset(Offset = "0xC")]
	public float TypewriteOneCharSecond;

	[Token(Token = "0x4005F6B")]
	[FieldOffset(Offset = "0x10")]
	public GameObject BlackMask;

	[Token(Token = "0x4005F6C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SubtitelLabel;

	[Token(Token = "0x4005F6D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PointAnimLabel;

	[Token(Token = "0x4005F6E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AdjustLabel;

	[Token(Token = "0x4005F6F")]
	[FieldOffset(Offset = "0x20")]
	public List<string> LocKey;

	[Token(Token = "0x4005F70")]
	[FieldOffset(Offset = "0x24")]
	public List<string> FinishLocKey;

	[Token(Token = "0x4005F71")]
	[FieldOffset(Offset = "0x28")]
	public float ShowDelta;

	[Token(Token = "0x4005F72")]
	[FieldOffset(Offset = "0x2C")]
	private int curKeyIndex;

	[Token(Token = "0x4005F73")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_Coroutine;

	[Token(Token = "0x4005F74")]
	[FieldOffset(Offset = "0x34")]
	private List<string> m_CurTypeKeyList;

	[Token(Token = "0x4005F75")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsTypeBeginSwitch;

	[Token(Token = "0x4005F76")]
	[FieldOffset(Offset = "0x3C")]
	private AudioResource m_TypeSound;

	[Token(Token = "0x4005F77")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine m_PointCor;

	[Token(Token = "0x4005F78")]
	[FieldOffset(Offset = "0x44")]
	private int m_CurPointCount;

	[Token(Token = "0x4005F79")]
	[FieldOffset(Offset = "0x48")]
	public float PointAnimDelta;

	[Token(Token = "0x60054E1")]
	[Address(RVA = "0x2ED7B24", Offset = "0x2ED7B24", VA = "0x2ED7B24")]
	public BountySwitchSceneSubtitleController()
	{
	}

	[Token(Token = "0x60054E2")]
	[Address(RVA = "0x2ED7BDC", Offset = "0x2ED7BDC", VA = "0x2ED7BDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054E3")]
	[Address(RVA = "0x2ED7DCC", Offset = "0x2ED7DCC", VA = "0x2ED7DCC")]
	private void Start()
	{
	}

	[Token(Token = "0x60054E4")]
	[Address(RVA = "0x2ED7E24", Offset = "0x2ED7E24", VA = "0x2ED7E24")]
	public void PlayBeginSwitch()
	{
	}

	[Token(Token = "0x60054E5")]
	[Address(RVA = "0x2ED8208", Offset = "0x2ED8208", VA = "0x2ED8208")]
	public void PlayFinishSwitch()
	{
	}

	[Token(Token = "0x60054E6")]
	[Address(RVA = "0x2ED82EC", Offset = "0x2ED82EC", VA = "0x2ED82EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60054E7")]
	[Address(RVA = "0x2ED83B8", Offset = "0x2ED83B8", VA = "0x2ED83B8")]
	private IEnumerator CoTypeLabel(UILabel label, string str)
	{
		return null;
	}

	[Token(Token = "0x60054E8")]
	[Address(RVA = "0x2ED8478", Offset = "0x2ED8478", VA = "0x2ED8478")]
	private void PlayTypeSound()
	{
	}

	[Token(Token = "0x60054E9")]
	[Address(RVA = "0x2ED82F0", Offset = "0x2ED82F0", VA = "0x2ED82F0")]
	private void StopTypeSound()
	{
	}

	[Token(Token = "0x60054EA")]
	[Address(RVA = "0x2ED855C", Offset = "0x2ED855C", VA = "0x2ED855C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054EB")]
	[Address(RVA = "0x2ED8560", Offset = "0x2ED8560", VA = "0x2ED8560")]
	private void OnCurTypewriteFinsih()
	{
	}

	[Token(Token = "0x60054EC")]
	[Address(RVA = "0x2ED7F20", Offset = "0x2ED7F20", VA = "0x2ED7F20")]
	private void ShowSubtitle()
	{
	}

	[Token(Token = "0x60054ED")]
	[Address(RVA = "0x2ED8620", Offset = "0x2ED8620", VA = "0x2ED8620")]
	private void PlayLoadingPoint()
	{
	}

	[Token(Token = "0x60054EE")]
	[Address(RVA = "0x2ED8690", Offset = "0x2ED8690", VA = "0x2ED8690")]
	private IEnumerator PointAnim()
	{
		return null;
	}
}
