using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000139")]
public class FriendTagRuleDataManager : SingletonModule<FriendTagRuleDataManager>
{
	[Token(Token = "0x200013A")]
	private sealed class _003CGetTagData_003Ec__AnonStorey0
	{
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x8")]
		internal RecommendedFriendTag tag;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xDF2808", Offset = "0xDF2808", VA = "0xDF2808")]
		public _003CGetTagData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xDF2810", Offset = "0xDF2810", VA = "0xDF2810")]
		internal bool _003C_003Em__0(FriendTagRuleData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0xC")]
	public List<FriendTagRuleData> m_FriendTagRoleDataList;

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xDF24B4", Offset = "0xDF24B4", VA = "0xDF24B4")]
	public FriendTagRuleDataManager()
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0xDF2544", Offset = "0xDF2544", VA = "0xDF2544", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0xDF2668", Offset = "0xDF2668", VA = "0xDF2668", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0xDF26C4", Offset = "0xDF26C4", VA = "0xDF26C4")]
	public FriendTagRuleData GetTagData(RecommendedFriendTag tag)
	{
		return null;
	}
}
