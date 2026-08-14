using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E2A")]
public class TeamClothPrivilegeManager : SingletonModule<TeamClothPrivilegeManager>
{
	[Token(Token = "0x400BE83")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, TeamConfigData> m_dictIdToTeamConfig;

	[Token(Token = "0x400BE84")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, PrivilegeData> m_dictIdToPrivilegeData;

	[Token(Token = "0x400BE85")]
	[FieldOffset(Offset = "0x14")]
	private uint m_ActiveTeamId;

	[Token(Token = "0x400BE86")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID m_ResourceId;

	[Token(Token = "0x400BE87")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> m_PrivbiligeTypeToIcon;

	[Token(Token = "0x400BE88")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<int, string> m_PrivbiligeTypeToTitle;

	[Token(Token = "0x400BE89")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, string> m_PrivbiligeTypeToDesc;

	[Token(Token = "0x400BE8A")]
	[FieldOffset(Offset = "0xC")]
	private static Func<uint, uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400BE8B")]
	[FieldOffset(Offset = "0x10")]
	private static Func<KeyValuePair<uint, uint>, uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400BE8C")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<uint> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17000F23")]
	public ResourceID ResourceId
	{
		[Token(Token = "0x600906D")]
		[Address(RVA = "0x289AC3C", Offset = "0x289AC3C", VA = "0x289AC3C")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x600906E")]
		[Address(RVA = "0x289AC94", Offset = "0x289AC94", VA = "0x289AC94")]
		set
		{
		}
	}

	[Token(Token = "0x600906C")]
	[Address(RVA = "0x289AAFC", Offset = "0x289AAFC", VA = "0x289AAFC")]
	public TeamClothPrivilegeManager()
	{
	}

	[Token(Token = "0x600906F")]
	[Address(RVA = "0x289ACF4", Offset = "0x289ACF4", VA = "0x289ACF4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6009070")]
	[Address(RVA = "0x289AE40", Offset = "0x289AE40", VA = "0x289AE40", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6009071")]
	[Address(RVA = "0x289B020", Offset = "0x289B020", VA = "0x289B020")]
	public List<TeamClothPrivilegeDetail> GetClothPrivilegeDetailByID(uint Id)
	{
		return null;
	}

	[Token(Token = "0x6009072")]
	[Address(RVA = "0x289B8DC", Offset = "0x289B8DC", VA = "0x289B8DC")]
	public bool CheckClothPrivilegeById(uint Id)
	{
		return default(bool);
	}

	[Token(Token = "0x6009073")]
	[Address(RVA = "0x289BAC4", Offset = "0x289BAC4", VA = "0x289BAC4")]
	public uint GetPrivilegeClothIdById(uint Id)
	{
		return default(uint);
	}

	[Token(Token = "0x6009074")]
	[Address(RVA = "0x289BF3C", Offset = "0x289BF3C", VA = "0x289BF3C")]
	public void CheckClothPrivilege(List<UIMaleAvatar> avatars)
	{
	}

	[Token(Token = "0x6009075")]
	[Address(RVA = "0x289CCAC", Offset = "0x289CCAC", VA = "0x289CCAC")]
	private void ApplicatePrivilege(uint teamId)
	{
	}

	[Token(Token = "0x6009076")]
	[Address(RVA = "0x289BFE4", Offset = "0x289BFE4", VA = "0x289BFE4")]
	public uint CheckActiveTeamID(List<UIMaleAvatar> avatars)
	{
		return default(uint);
	}

	[Token(Token = "0x6009077")]
	[Address(RVA = "0x289C84C", Offset = "0x289C84C", VA = "0x289C84C")]
	public void CancleCurrentPrivilege()
	{
	}

	[Token(Token = "0x6009079")]
	[Address(RVA = "0x289D2E0", Offset = "0x289D2E0", VA = "0x289D2E0")]
	private static uint _003CCheckActiveTeamID_003Em__0(uint o)
	{
		return default(uint);
	}

	[Token(Token = "0x600907A")]
	[Address(RVA = "0x289D390", Offset = "0x289D390", VA = "0x289D390")]
	private bool _003CCheckActiveTeamID_003Em__1(KeyValuePair<uint, uint> entry)
	{
		return default(bool);
	}

	[Token(Token = "0x600907B")]
	[Address(RVA = "0x289D478", Offset = "0x289D478", VA = "0x289D478")]
	private static uint _003CCheckActiveTeamID_003Em__2(KeyValuePair<uint, uint> entry)
	{
		return default(uint);
	}

	[Token(Token = "0x600907C")]
	[Address(RVA = "0x289D4E8", Offset = "0x289D4E8", VA = "0x289D4E8")]
	private static int _003CCheckActiveTeamID_003Em__3(uint a, uint b)
	{
		return default(int);
	}
}
