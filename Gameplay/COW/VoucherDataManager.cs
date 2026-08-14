using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032CC")]
internal class VoucherDataManager : SingletonModule<VoucherDataManager>
{
	[Token(Token = "0x20032CD")]
	private sealed class _003CFindVoucherDataByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x401356D")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60156D7")]
		[Address(RVA = "0x21A1D5C", Offset = "0x21A1D5C", VA = "0x21A1D5C")]
		public _003CFindVoucherDataByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60156D8")]
		[Address(RVA = "0x21A1D64", Offset = "0x21A1D64", VA = "0x21A1D64")]
		internal bool _003C_003Em__0(VoucherData data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401356C")]
	[FieldOffset(Offset = "0xC")]
	private List<VoucherData> m_VoucherDataList;

	[Token(Token = "0x170016B4")]
	public List<VoucherData> VoucherDataList
	{
		[Token(Token = "0x60156D3")]
		[Address(RVA = "0x21A19D0", Offset = "0x21A19D0", VA = "0x21A19D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60156D2")]
	[Address(RVA = "0x21A190C", Offset = "0x21A190C", VA = "0x21A190C")]
	public VoucherDataManager()
	{
	}

	[Token(Token = "0x60156D4")]
	[Address(RVA = "0x21A1A28", Offset = "0x21A1A28", VA = "0x21A1A28", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60156D5")]
	[Address(RVA = "0x21A1B50", Offset = "0x21A1B50", VA = "0x21A1B50", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60156D6")]
	[Address(RVA = "0x21A1C18", Offset = "0x21A1C18", VA = "0x21A1C18")]
	public VoucherData FindVoucherDataByID(uint id)
	{
		return null;
	}
}
