using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A98")]
public class FullscreenCgDesc
{
	[Token(Token = "0x400A68E")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A68F")]
	[FieldOffset(Offset = "0xC")]
	public uint anim_id;

	[Token(Token = "0x400A690")]
	[FieldOffset(Offset = "0x10")]
	public uint anim_type;

	[Token(Token = "0x400A691")]
	[FieldOffset(Offset = "0x14")]
	public uint system_pos;

	[Token(Token = "0x400A692")]
	[FieldOffset(Offset = "0x18")]
	public uint go_pos;

	[Token(Token = "0x400A693")]
	[FieldOffset(Offset = "0x1C")]
	public string fullscreen_resource_id;

	[Token(Token = "0x400A694")]
	[FieldOffset(Offset = "0x20")]
	public uint first_model_id;

	[Token(Token = "0x400A695")]
	[FieldOffset(Offset = "0x24")]
	public uint first_model_cloth1;

	[Token(Token = "0x400A696")]
	[FieldOffset(Offset = "0x28")]
	public uint first_model_cloth2;

	[Token(Token = "0x400A697")]
	[FieldOffset(Offset = "0x2C")]
	public uint first_model_cloth3;

	[Token(Token = "0x400A698")]
	[FieldOffset(Offset = "0x30")]
	public uint first_model_cloth4;

	[Token(Token = "0x400A699")]
	[FieldOffset(Offset = "0x34")]
	public uint first_model_cloth5;

	[Token(Token = "0x400A69A")]
	[FieldOffset(Offset = "0x38")]
	public uint second_model_id;

	[Token(Token = "0x400A69B")]
	[FieldOffset(Offset = "0x3C")]
	public uint second_model_cloth1;

	[Token(Token = "0x400A69C")]
	[FieldOffset(Offset = "0x40")]
	public uint second_model_cloth2;

	[Token(Token = "0x400A69D")]
	[FieldOffset(Offset = "0x44")]
	public uint second_model_cloth3;

	[Token(Token = "0x400A69E")]
	[FieldOffset(Offset = "0x48")]
	public uint second_model_cloth4;

	[Token(Token = "0x400A69F")]
	[FieldOffset(Offset = "0x4C")]
	public uint second_model_cloth5;

	[Token(Token = "0x400A6A0")]
	[FieldOffset(Offset = "0x50")]
	public string first_model_female_idle;

	[Token(Token = "0x400A6A1")]
	[FieldOffset(Offset = "0x54")]
	public string first_model_female_special;

	[Token(Token = "0x400A6A2")]
	[FieldOffset(Offset = "0x58")]
	public string first_model_male_idle;

	[Token(Token = "0x400A6A3")]
	[FieldOffset(Offset = "0x5C")]
	public string first_model_male_special;

	[Token(Token = "0x400A6A4")]
	[FieldOffset(Offset = "0x60")]
	public string second_model_female_idle;

	[Token(Token = "0x400A6A5")]
	[FieldOffset(Offset = "0x64")]
	public string second_model_female_special;

	[Token(Token = "0x400A6A6")]
	[FieldOffset(Offset = "0x68")]
	public string second_model_male_idle;

	[Token(Token = "0x400A6A7")]
	[FieldOffset(Offset = "0x6C")]
	public string second_model_male_special;

	[Token(Token = "0x400A6A8")]
	[FieldOffset(Offset = "0x70")]
	public List<string> skin_resource_list;

	[Token(Token = "0x60080F5")]
	[Address(RVA = "0x30A1574", Offset = "0x30A1574", VA = "0x30A1574")]
	public FullscreenCgDesc()
	{
	}
}
