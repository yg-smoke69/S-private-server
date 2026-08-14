using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x200211E")]
public static class UIHDLobbyAnimationData
{
	[Token(Token = "0x200211F")]
	public class AnimationData
	{
		[Token(Token = "0x400CF7D")]
		[FieldOffset(Offset = "0x8")]
		public int m_Frame;

		[Token(Token = "0x400CF7E")]
		[FieldOffset(Offset = "0x10")]
		public double m_Speed;

		[Token(Token = "0x400CF7F")]
		[FieldOffset(Offset = "0x18")]
		public double m_PositionX;

		[Token(Token = "0x600AD62")]
		[Address(RVA = "0x147E348", Offset = "0x147E348", VA = "0x147E348")]
		public AnimationData()
		{
		}
	}

	[Token(Token = "0x400CF75")]
	[FieldOffset(Offset = "0x0")]
	public static string m_CurrentAnimationName;

	[Token(Token = "0x400CF76")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, Dictionary<int, int>> m_AnimationIndexData;

	[Token(Token = "0x400CF77")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, List<AnimationData>> m_AnimationData;

	[Token(Token = "0x400CF78")]
	[FieldOffset(Offset = "0xC")]
	private static float m_ScreenRate;

	[Token(Token = "0x400CF79")]
	[FieldOffset(Offset = "0x10")]
	private static int m_LastIndex;

	[Token(Token = "0x400CF7A")]
	[FieldOffset(Offset = "0x14")]
	private static bool m_hasInited;

	[Token(Token = "0x400CF7B")]
	[FieldOffset(Offset = "0x18")]
	private static ResourceID[] m_ResourceData;

	[Token(Token = "0x400CF7C")]
	[FieldOffset(Offset = "0x1C")]
	private static string[] m_AnimationNames;

	[Token(Token = "0x600AD5E")]
	[Address(RVA = "0x147CF24", Offset = "0x147CF24", VA = "0x147CF24")]
	public static void InitData()
	{
	}

	[Token(Token = "0x600AD5F")]
	[Address(RVA = "0x147D2BC", Offset = "0x147D2BC", VA = "0x147D2BC")]
	private static bool InitDataWithSingleFile(ResourceID resourceID, string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600AD60")]
	[Address(RVA = "0x147DA04", Offset = "0x147DA04", VA = "0x147DA04")]
	public static AnimationData GetData(float rate)
	{
		return null;
	}
}
