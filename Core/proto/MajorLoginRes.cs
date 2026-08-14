using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001721")]
public class MajorLoginRes
{
	[Token(Token = "0x4009906")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009907")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x4009908")]
	[FieldOffset(Offset = "0x14")]
	public string noti_region;

	[Token(Token = "0x4009909")]
	[FieldOffset(Offset = "0x18")]
	public string ip_region;

	[Token(Token = "0x400990A")]
	[FieldOffset(Offset = "0x1C")]
	public string agora_environment;

	[Token(Token = "0x400990B")]
	[FieldOffset(Offset = "0x20")]
	public string new_active_region;

	[Token(Token = "0x400990C")]
	[FieldOffset(Offset = "0x24")]
	public List<string> recommend_regions;

	[Token(Token = "0x400990D")]
	[FieldOffset(Offset = "0x28")]
	public string token;

	[Token(Token = "0x400990E")]
	[FieldOffset(Offset = "0x2C")]
	public uint ttl;

	[Token(Token = "0x400990F")]
	[FieldOffset(Offset = "0x30")]
	public string server_url;

	[Token(Token = "0x4009910")]
	[FieldOffset(Offset = "0x34")]
	public uint emulator_score;

	[Token(Token = "0x4009911")]
	[FieldOffset(Offset = "0x38")]
	public BlacklistInfoRes blacklist;

	[Token(Token = "0x4009912")]
	[FieldOffset(Offset = "0x3C")]
	public LoginQueueInfo queue_info;

	[Token(Token = "0x4009913")]
	[FieldOffset(Offset = "0x40")]
	public string tp_url;

	[Token(Token = "0x4009914")]
	[FieldOffset(Offset = "0x44")]
	public uint app_server_id;

	[Token(Token = "0x4009915")]
	[FieldOffset(Offset = "0x48")]
	public string ano_url;

	[Token(Token = "0x4009916")]
	[FieldOffset(Offset = "0x4C")]
	public string ip_city;

	[Token(Token = "0x4009917")]
	[FieldOffset(Offset = "0x50")]
	public string ip_subdivision;

	[Token(Token = "0x6007D7B")]
	[Address(RVA = "0x30A7654", Offset = "0x30A7654", VA = "0x30A7654")]
	public MajorLoginRes()
	{
	}
}
