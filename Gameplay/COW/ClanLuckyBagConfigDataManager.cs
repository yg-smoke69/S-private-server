using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DBE")]
internal class ClanLuckyBagConfigDataManager : SingletonModule<ClanLuckyBagConfigDataManager>
{
	[Token(Token = "0x40118B8")]
	[FieldOffset(Offset = "0xC")]
	private ClanLuckyBagConfigData _003CData_003Ek__BackingField;

	[Token(Token = "0x1700139B")]
	public ClanLuckyBagConfigData Data
	{
		[Token(Token = "0x601325C")]
		[Address(RVA = "0x172B3D8", Offset = "0x172B3D8", VA = "0x172B3D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601325D")]
		[Address(RVA = "0x172B3E0", Offset = "0x172B3E0", VA = "0x172B3E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700139C")]
	public ClanLuckyBagConfigData ClanLuckyBagConfigData
	{
		[Token(Token = "0x601325E")]
		[Address(RVA = "0x172B3E8", Offset = "0x172B3E8", VA = "0x172B3E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601325B")]
	[Address(RVA = "0x172B348", Offset = "0x172B348", VA = "0x172B348")]
	public ClanLuckyBagConfigDataManager()
	{
	}

	[Token(Token = "0x601325F")]
	[Address(RVA = "0x172B440", Offset = "0x172B440", VA = "0x172B440", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013260")]
	[Address(RVA = "0x172B5AC", Offset = "0x172B5AC", VA = "0x172B5AC", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
