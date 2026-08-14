using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A1")]
public static class UDPParameters
{
	[Token(Token = "0x401B251")]
	[FieldOffset(Offset = "0x0")]
	public static int MAX_RESEND_COUNT;

	[Token(Token = "0x401B252")]
	[FieldOffset(Offset = "0x8")]
	public static double RESEND_TIMEOUT;

	[Token(Token = "0x401B253")]
	[FieldOffset(Offset = "0x10")]
	public static double FIRST_RESEND_TIMEOUT;

	[Token(Token = "0x401B254")]
	[FieldOffset(Offset = "0x18")]
	public static double MAX_RESEND_TIMEOUT;

	[Token(Token = "0x401B255")]
	[FieldOffset(Offset = "0x20")]
	public static double DEFAULT_DEACTIVE_TIME;

	[Token(Token = "0x401B256")]
	[FieldOffset(Offset = "0x28")]
	public static int MTU_LIMIT;

	[Token(Token = "0x401B257")]
	[FieldOffset(Offset = "0x2C")]
	public static byte[] SECRET_KEY;

	[Token(Token = "0x401B258")]
	[FieldOffset(Offset = "0x30")]
	public static int JOIN_TIMEOUT;

	[Token(Token = "0x401B259")]
	[FieldOffset(Offset = "0x38")]
	public static double RECONNECT_DELAY;

	[Token(Token = "0x401B25A")]
	[FieldOffset(Offset = "0x40")]
	public static int MIN_RECV_SLEEP_TIME;

	[Token(Token = "0x401B25B")]
	[FieldOffset(Offset = "0x48")]
	public static double FLUSH_RESEND_DEACTIVVE_TIME;

	[Token(Token = "0x401B25C")]
	[FieldOffset(Offset = "0x50")]
	public static double FLUSH_RESEND_DELTA_TIME;

	[Token(Token = "0x401B25D")]
	[FieldOffset(Offset = "0x58")]
	public static double FLUSH_RESEND_INTERVAL_TIME;

	[Token(Token = "0x401B25E")]
	[FieldOffset(Offset = "0x60")]
	public static bool ENABLE_PACKAGE_POOL;

	[Token(Token = "0x401B25F")]
	[FieldOffset(Offset = "0x61")]
	public static bool ENABLE_MESSAGE_POOL;

	[Token(Token = "0x401B260")]
	[FieldOffset(Offset = "0x64")]
	public static float FORCE_RECONNECT_TIMEOUT;

	[Token(Token = "0x401B261")]
	[FieldOffset(Offset = "0x68")]
	public static bool ENABEL_MESSAGE_POOL_OPTIMIZATION;

	[Token(Token = "0x401B262")]
	[FieldOffset(Offset = "0x69")]
	public static bool ENABLE_FAST_PROTO;

	[Token(Token = "0x401B263")]
	[FieldOffset(Offset = "0x6A")]
	public static bool ENABLE_RUDP_FAST_RESEND;

	[Token(Token = "0x401B264")]
	[FieldOffset(Offset = "0x6C")]
	public static int RUDP_FAST_RESEND_TIMEOUT_MAX_STEP_COUNT;

	[Token(Token = "0x401B265")]
	[FieldOffset(Offset = "0x70")]
	public static double RUDP_FAST_RESEND_TIMEOUT_STEP_INTERVAL;
}
