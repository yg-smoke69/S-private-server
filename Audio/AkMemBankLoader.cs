using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

[Token(Token = "0x2003E29")]
public class AkMemBankLoader : MonoBehaviour
{
	[Token(Token = "0x2003E2A")]
	private sealed class _003CLoadFile_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A538")]
		[FieldOffset(Offset = "0x8")]
		internal uint _003CuInMemoryBankSize_003E__0;

		[Token(Token = "0x401A539")]
		[FieldOffset(Offset = "0xC")]
		internal AKRESULT _003Cresult_003E__0;

		[Token(Token = "0x401A53A")]
		[FieldOffset(Offset = "0x10")]
		internal AkMemBankLoader _0024this;

		[Token(Token = "0x401A53B")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x401A53C")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x401A53D")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001B89")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601945A")]
			[Address(RVA = "0x36B9500", Offset = "0x36B9500", VA = "0x36B9500", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001B8A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601945B")]
			[Address(RVA = "0x36B9508", Offset = "0x36B9508", VA = "0x36B9508", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6019458")]
		[Address(RVA = "0x36B9050", Offset = "0x36B9050", VA = "0x36B9050")]
		public _003CLoadFile_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6019459")]
		[Address(RVA = "0x36B91A0", Offset = "0x36B91A0", VA = "0x36B91A0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601945C")]
		[Address(RVA = "0x36B9510", Offset = "0x36B9510", VA = "0x36B9510", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601945D")]
		[Address(RVA = "0x36B9524", Offset = "0x36B9524", VA = "0x36B9524", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401A52E")]
	private const int WaitMs = 50;

	[Token(Token = "0x401A52F")]
	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16L;

	[Token(Token = "0x401A530")]
	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15L;

	[Token(Token = "0x401A531")]
	[FieldOffset(Offset = "0xC")]
	public string bankName;

	[Token(Token = "0x401A532")]
	[FieldOffset(Offset = "0x10")]
	public bool isLocalizedBank;

	[Token(Token = "0x401A533")]
	[FieldOffset(Offset = "0x14")]
	private string m_bankPath;

	[Token(Token = "0x401A534")]
	[FieldOffset(Offset = "0x18")]
	public uint ms_bankID;

	[Token(Token = "0x401A535")]
	[FieldOffset(Offset = "0x1C")]
	private IntPtr ms_pInMemoryBankPtr;

	[Token(Token = "0x401A536")]
	[FieldOffset(Offset = "0x20")]
	private GCHandle ms_pinnedArray;

	[Token(Token = "0x401A537")]
	[FieldOffset(Offset = "0x24")]
	private UnityWebRequest ms_www;

	[Token(Token = "0x6019450")]
	[Address(RVA = "0x36B88C0", Offset = "0x36B88C0", VA = "0x36B88C0")]
	public AkMemBankLoader()
	{
	}

	[Token(Token = "0x6019451")]
	[Address(RVA = "0x36B8968", Offset = "0x36B8968", VA = "0x36B8968")]
	private void Start()
	{
	}

	[Token(Token = "0x6019452")]
	[Address(RVA = "0x36B8AEC", Offset = "0x36B8AEC", VA = "0x36B8AEC")]
	public void LoadNonLocalizedBank(string in_bankFilename)
	{
	}

	[Token(Token = "0x6019453")]
	[Address(RVA = "0x36B8980", Offset = "0x36B8980", VA = "0x36B8980")]
	public void LoadLocalizedBank(string in_bankFilename)
	{
	}

	[Token(Token = "0x6019454")]
	[Address(RVA = "0x36B8CF4", Offset = "0x36B8CF4", VA = "0x36B8CF4")]
	private uint AllocateAlignedBuffer(byte[] data)
	{
		return default(uint);
	}

	[Token(Token = "0x6019455")]
	[Address(RVA = "0x36B8FCC", Offset = "0x36B8FCC", VA = "0x36B8FCC")]
	private IEnumerator LoadFile()
	{
		return null;
	}

	[Token(Token = "0x6019456")]
	[Address(RVA = "0x36B8C18", Offset = "0x36B8C18", VA = "0x36B8C18")]
	private void DoLoadBank(string in_bankPath)
	{
	}

	[Token(Token = "0x6019457")]
	[Address(RVA = "0x36B9058", Offset = "0x36B9058", VA = "0x36B9058")]
	private void OnDestroy()
	{
	}
}
