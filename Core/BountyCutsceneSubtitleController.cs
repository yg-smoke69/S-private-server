using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B04")]
public class BountyCutsceneSubtitleController : MonoBehaviour
{
	[Token(Token = "0x2000B05")]
	private sealed class _003CCoTypeLabel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005F50")]
		[FieldOffset(Offset = "0x8")]
		internal UILabel label;

		[Token(Token = "0x4005F51")]
		[FieldOffset(Offset = "0xC")]
		internal string str;

		[Token(Token = "0x4005F52")]
		[FieldOffset(Offset = "0x10")]
		internal char[] _0024locvar0;

		[Token(Token = "0x4005F53")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024locvar1;

		[Token(Token = "0x4005F54")]
		[FieldOffset(Offset = "0x18")]
		internal char _003Cletter_003E__1;

		[Token(Token = "0x4005F55")]
		[FieldOffset(Offset = "0x1C")]
		internal BountyCutsceneSubtitleController _0024this;

		[Token(Token = "0x4005F56")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4005F57")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4005F58")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x170006D4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60054BC")]
			[Address(RVA = "0x2ED566C", Offset = "0x2ED566C", VA = "0x2ED566C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60054BD")]
			[Address(RVA = "0x2ED5674", Offset = "0x2ED5674", VA = "0x2ED5674", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x2ED51A4", Offset = "0x2ED51A4", VA = "0x2ED51A4")]
		public _003CCoTypeLabel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x2ED533C", Offset = "0x2ED533C", VA = "0x2ED533C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x2ED567C", Offset = "0x2ED567C", VA = "0x2ED567C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x2ED5690", Offset = "0x2ED5690", VA = "0x2ED5690", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005F48")]
	[FieldOffset(Offset = "0xC")]
	public float TypewriteOneCharSecond;

	[Token(Token = "0x4005F49")]
	[FieldOffset(Offset = "0x10")]
	public UILabel SubtitelLabel;

	[Token(Token = "0x4005F4A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel AdjustLabel;

	[Token(Token = "0x4005F4B")]
	[FieldOffset(Offset = "0x18")]
	public List<string> LocKey;

	[Token(Token = "0x4005F4C")]
	[FieldOffset(Offset = "0x1C")]
	public float ShowDelta;

	[Token(Token = "0x4005F4D")]
	[FieldOffset(Offset = "0x20")]
	private int curKeyIndex;

	[Token(Token = "0x4005F4E")]
	[FieldOffset(Offset = "0x24")]
	private Coroutine m_Coroutine;

	[Token(Token = "0x4005F4F")]
	[FieldOffset(Offset = "0x28")]
	private AudioResource m_TypeSound;

	[Token(Token = "0x60054B1")]
	[Address(RVA = "0x2ED4C40", Offset = "0x2ED4C40", VA = "0x2ED4C40")]
	public BountyCutsceneSubtitleController()
	{
	}

	[Token(Token = "0x60054B2")]
	[Address(RVA = "0x2ED4CD4", Offset = "0x2ED4CD4", VA = "0x2ED4CD4")]
	private void Start()
	{
	}

	[Token(Token = "0x60054B3")]
	[Address(RVA = "0x2ED5020", Offset = "0x2ED5020", VA = "0x2ED5020")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60054B4")]
	[Address(RVA = "0x2ED50EC", Offset = "0x2ED50EC", VA = "0x2ED50EC")]
	private IEnumerator CoTypeLabel(UILabel label, string str)
	{
		return null;
	}

	[Token(Token = "0x60054B5")]
	[Address(RVA = "0x2ED51AC", Offset = "0x2ED51AC", VA = "0x2ED51AC")]
	private void PlayTypeSound()
	{
	}

	[Token(Token = "0x60054B6")]
	[Address(RVA = "0x2ED5024", Offset = "0x2ED5024", VA = "0x2ED5024")]
	private void StopTypeSound()
	{
	}

	[Token(Token = "0x60054B7")]
	[Address(RVA = "0x2ED5290", Offset = "0x2ED5290", VA = "0x2ED5290")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054B8")]
	[Address(RVA = "0x2ED5294", Offset = "0x2ED5294", VA = "0x2ED5294")]
	private void OnCurTypewriteFinsih()
	{
	}

	[Token(Token = "0x60054B9")]
	[Address(RVA = "0x2ED4D38", Offset = "0x2ED4D38", VA = "0x2ED4D38")]
	private void ShowSubtitle()
	{
	}
}
