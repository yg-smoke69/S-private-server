using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000201")]
public class PlayerSocialTagsDataManager : SingletonModule<PlayerSocialTagsDataManager>
{
	[Token(Token = "0x2000202")]
	private sealed class _003CGetPlayerSocialTagsByType_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x1C0C0D0", Offset = "0x1C0C0D0", VA = "0x1C0C0D0")]
		public _003CGetPlayerSocialTagsByType_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x1C0C0D8", Offset = "0x1C0C0D8", VA = "0x1C0C0D8")]
		internal bool _003C_003Em__0(PlayerSocialTagsData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0xC")]
	private List<PlayerSocialTagsData> m_ListData;

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x1C0B98C", Offset = "0x1C0B98C", VA = "0x1C0B98C")]
	public PlayerSocialTagsDataManager()
	{
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x1C0BA50", Offset = "0x1C0BA50", VA = "0x1C0BA50", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x1C0BC9C", Offset = "0x1C0BC9C", VA = "0x1C0BC9C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x1C0BD5C", Offset = "0x1C0BD5C", VA = "0x1C0BD5C")]
	public string GetSocicalKeyById(uint typeid, uint sortid)
	{
		return null;
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x1C0BF58", Offset = "0x1C0BF58", VA = "0x1C0BF58")]
	public List<PlayerSocialTagsData> GetPlayerSocialTagsByType(uint type)
	{
		return null;
	}
}
