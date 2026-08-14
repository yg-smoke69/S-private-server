using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001315")]
public class EGroup
{
	[Token(Token = "0x2001316")]
	public enum StatusChangeReason
	{
		[Token(Token = "0x4008706")]
		StatusChangeReason_NONE,
		[Token(Token = "0x4008707")]
		StatusChangeReason_STARTMATCH,
		[Token(Token = "0x4008708")]
		StatusChangeReason_ENDMATCH,
		[Token(Token = "0x4008709")]
		StatusChangeReason_DROPMATCH,
		[Token(Token = "0x400870A")]
		StatusChangeReason_MATCHMAKINGTIMEOUT,
		[Token(Token = "0x400870B")]
		StatusChangeReason_JOINROOM,
		[Token(Token = "0x400870C")]
		StatusChangeReason_EMULATOR,
		[Token(Token = "0x400870D")]
		StatusChangeReason_UPDATEINGAMEITEMS
	}

	[Token(Token = "0x2001317")]
	public enum ChangeMatchInfoEvent
	{
		[Token(Token = "0x400870F")]
		ChangeMatchInfoEvent_NONE,
		[Token(Token = "0x4008710")]
		ChangeMatchInfoEvent_ENDMATCH,
		[Token(Token = "0x4008711")]
		ChangeMatchInfoEvent_CHOOSELOADOUTS,
		[Token(Token = "0x4008712")]
		ChangeMatchInfoEvent_CHOOSEPVEWEAPON,
		[Token(Token = "0x4008713")]
		ChangeMatchInfoEvent_CHOOSEEMOTE,
		[Token(Token = "0x4008714")]
		ChangeMatchInfoEvent_ANTIADDICTIONBAN,
		[Token(Token = "0x4008715")]
		ChangeMatchInfoEvent_CHOOSECLOTHES,
		[Token(Token = "0x4008716")]
		ChangeMatchInfoEvent_ACCOUNTHACKERTAG,
		[Token(Token = "0x4008717")]
		ChangeMatchInfoEvent_EQUIPSKILLS,
		[Token(Token = "0x4008718")]
		ChangeMatchInfoEvent_SELECTPET,
		[Token(Token = "0x4008719")]
		ChangeMatchInfoEvent_UPGRADEPET,
		[Token(Token = "0x400871A")]
		ChangeMatchInfoEvent_RENAMEPET,
		[Token(Token = "0x400871B")]
		ChangeMatchInfoEvent_SELECTPETSKIN,
		[Token(Token = "0x400871C")]
		ChangeMatchInfoEvent_SELECTPETSKILL,
		[Token(Token = "0x400871D")]
		ChangeMatchInfoEvent_SELECTPROFILE,
		[Token(Token = "0x400871E")]
		ChangeMatchInfoEvent_CHOOSESLOTS,
		[Token(Token = "0x400871F")]
		ChangeMatchInfoEvent_CHOOSESHOWS,
		[Token(Token = "0x4008720")]
		ChangeMatchInfoEvent_CHOOSEBANNER,
		[Token(Token = "0x4008721")]
		ChangeMatchInfoEvent_CHOOSEPIN,
		[Token(Token = "0x4008722")]
		ChangeMatchInfoEvent_CHOOSEHEADPIC,
		[Token(Token = "0x4008723")]
		ChangeMatchInfoEvent_CHOOSEGAMEBAGSHOW
	}

	[Token(Token = "0x6007A4D")]
	[Address(RVA = "0x309F2F0", Offset = "0x309F2F0", VA = "0x309F2F0")]
	public EGroup()
	{
	}
}
