using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D9")]
public class CloseBetaGetKeyDataManager : SingletonModule<CloseBetaGetKeyDataManager>
{
	[Token(Token = "0x20000DA")]
	private sealed class _003CGetUrl_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x8")]
		internal string region;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x172E228", Offset = "0x172E228", VA = "0x172E228")]
		public _003CGetUrl_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x172E230", Offset = "0x172E230", VA = "0x172E230")]
		internal bool _003C_003Em__0(CloseBetaGetKeyData x)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x172E2D4", Offset = "0x172E2D4", VA = "0x172E2D4")]
		internal bool _003C_003Em__1(CloseBetaGetKeyData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0xC")]
	public List<CloseBetaGetKeyData> m_MaxVersionCdkeyUrlDataList;

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x172DE30", Offset = "0x172DE30", VA = "0x172DE30")]
	public CloseBetaGetKeyDataManager()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x172DEC0", Offset = "0x172DEC0", VA = "0x172DEC0", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x172DFE4", Offset = "0x172DFE4", VA = "0x172DFE4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x172E040", Offset = "0x172E040", VA = "0x172E040")]
	public string GetUrl(string region)
	{
		return null;
	}
}
