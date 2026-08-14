using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200018A")]
public class LoginQualityBgDataManager : SingletonModule<LoginQualityBgDataManager>
{
	[Token(Token = "0x200018B")]
	private sealed class _003CGetQualityDataByCountryCode_003Ec__AnonStorey0
	{
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x8")]
		internal string CountryCode;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x152D6F8", Offset = "0x152D6F8", VA = "0x152D6F8")]
		public _003CGetQualityDataByCountryCode_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x152D84C", Offset = "0x152D84C", VA = "0x152D84C")]
		internal bool _003C_003Em__0(LoginQualityBgData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200018C")]
	private sealed class _003CGetQualityDataById_003Ec__AnonStorey1
	{
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x8")]
		internal int LoginId;

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x152D844", Offset = "0x152D844", VA = "0x152D844")]
		public _003CGetQualityDataById_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x152D8F0", Offset = "0x152D8F0", VA = "0x152D8F0")]
		internal bool _003C_003Em__0(LoginQualityBgData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0xC")]
	public List<LoginQualityBgData> m_QulityBgList;

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x152D370", Offset = "0x152D370", VA = "0x152D370")]
	public LoginQualityBgDataManager()
	{
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x152D400", Offset = "0x152D400", VA = "0x152D400", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x152D524", Offset = "0x152D524", VA = "0x152D524", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x152D580", Offset = "0x152D580", VA = "0x152D580")]
	public LoginQualityBgData GetQualityDataByCountryCode(string CountryCode)
	{
		return null;
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x152D700", Offset = "0x152D700", VA = "0x152D700")]
	public LoginQualityBgData GetQualityDataById(int LoginId)
	{
		return null;
	}
}
