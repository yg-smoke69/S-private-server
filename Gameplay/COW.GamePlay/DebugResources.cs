using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using UMA;
using UMA.Simple;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20007B0")]
public static class DebugResources
{
	[Token(Token = "0x4004F6D")]
	private const string ResourceDir = "Assets/Resources/";

	[Token(Token = "0x4004F6E")]
	private const string SkipDir = "Assets/Resources/Avatar";

	[Token(Token = "0x4004F6F")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<Object, int>, int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4004F70")]
	[FieldOffset(Offset = "0x4")]
	private static Func<KeyValuePair<Object, KeyValuePair<int, int>>, long> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4004F71")]
	[FieldOffset(Offset = "0x8")]
	private static Func<KeyValuePair<Object, KeyValuePair<int, int>>, long> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4004F72")]
	[FieldOffset(Offset = "0xC")]
	private static Action<StreamWriter> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4004F73")]
	[FieldOffset(Offset = "0x10")]
	private static Action<StreamWriter> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x174C504", Offset = "0x174C504", VA = "0x174C504")]
	public static void FindDirsWithName(string dir, string name, List<string> dst)
	{
	}

	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x174C8F8", Offset = "0x174C8F8", VA = "0x174C8F8")]
	public static string OutputToTimeNamedFile(string fileNamePrefix, string ext, Action<StreamWriter> writer)
	{
		return null;
	}

	[Token(Token = "0x60030EB")]
	[Address(RVA = "0x174CA78", Offset = "0x174CA78", VA = "0x174CA78")]
	public static string OutputToFile(string file, Action<StreamWriter> writer)
	{
		return null;
	}

	[Token(Token = "0x60030EC")]
	[Address(RVA = "0x174CBE0", Offset = "0x174CBE0", VA = "0x174CBE0")]
	public static void OutputToPath(string path, bool truncate, Action<StreamWriter> writer)
	{
	}

	[Token(Token = "0x60030ED")]
	[Address(RVA = "0x174CF18", Offset = "0x174CF18", VA = "0x174CF18")]
	public static void OutputToPathes(string path1, string path2, bool truncate, Action<StreamWriter, StreamWriter> callback)
	{
	}

	[Token(Token = "0x60030EE")]
	[Address(RVA = "0x174CAF4", Offset = "0x174CAF4", VA = "0x174CAF4")]
	public static string GetOutputPath(string file)
	{
		return null;
	}

	[Token(Token = "0x60030EF")]
	[Address(RVA = "0x174D570", Offset = "0x174D570", VA = "0x174D570")]
	public static string GetFileOrDirName(string path)
	{
		return null;
	}

	[Token(Token = "0x60030F0")]
	[Address(RVA = "0x174D700", Offset = "0x174D700", VA = "0x174D700")]
	public static void WriteSize(TextWriter sw, long bytes)
	{
	}

	[Token(Token = "0x60030F1")]
	[Address(RVA = "0x174D884", Offset = "0x174D884", VA = "0x174D884")]
	private static bool WriteSize1024(TextWriter sw, long size, string token)
	{
		return default(bool);
	}

	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x174DA90", Offset = "0x174DA90", VA = "0x174DA90")]
	private static void WriteSizePadding(TextWriter sw, long bytes, int pad, bool addLine)
	{
	}

	[Token(Token = "0x60030F3")]
	[Address(RVA = "0x174DB94", Offset = "0x174DB94", VA = "0x174DB94")]
	private static void WriteSizesToTxt(string label, TextWriter sw, ICollection<KeyValuePair<Object, int>> dst)
	{
	}

	[Token(Token = "0x60030F4")]
	[Address(RVA = "0x174E2D0", Offset = "0x174E2D0", VA = "0x174E2D0")]
	private static void WriteSizesToTxt(string label, TextWriter sw, ICollection<KeyValuePair<Object, KeyValuePair<int, int>>> dst)
	{
	}

	[Token(Token = "0x60030F5")]
	[Address(RVA = "0x174ED38", Offset = "0x174ED38", VA = "0x174ED38")]
	private static int GetMemorySize(Object o)
	{
		return default(int);
	}

	[Token(Token = "0x60030F6")]
	private static void SortSizesDesc<T>(List<KeyValuePair<T, int>> list)
	{
	}

	[Token(Token = "0x60030F7")]
	private static void SortSizesDesc<T>(List<KeyValuePair<T, KeyValuePair<int, int>>> list)
	{
	}

	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x174EE0C", Offset = "0x174EE0C", VA = "0x174EE0C")]
	public static string OutputSceneAvatars()
	{
		return null;
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x174EFD4", Offset = "0x174EFD4", VA = "0x174EFD4")]
	private static void OutputAvatars(StreamWriter sw)
	{
	}

	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x174F728", Offset = "0x174F728", VA = "0x174F728")]
	private static void OutputAvatarSimple(StreamWriter sw, UmaAvatarSimple avatarSimple, bool renderEnabled)
	{
	}

	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x174FA28", Offset = "0x174FA28", VA = "0x174FA28")]
	private static void OutputAvatarRecipe(StreamWriter sw, UMAData.UMARecipe recipe)
	{
	}

	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x17508A0", Offset = "0x17508A0", VA = "0x17508A0")]
	private static void OutputAvatarRender(StreamWriter sw, SkinnedMeshRenderer render)
	{
	}

	[Token(Token = "0x60030FD")]
	[Address(RVA = "0x17514CC", Offset = "0x17514CC", VA = "0x17514CC")]
	private static int GetMeshVertsCount(UMAMeshAsset mesh)
	{
		return default(int);
	}

	[Token(Token = "0x60030FE")]
	[Address(RVA = "0x17515F4", Offset = "0x17515F4", VA = "0x17515F4")]
	public static string OutputSceneParticles()
	{
		return null;
	}

	[Token(Token = "0x60030FF")]
	[Address(RVA = "0x17517BC", Offset = "0x17517BC", VA = "0x17517BC")]
	private static void OutputSceneParticles(StreamWriter sw)
	{
	}

	[Token(Token = "0x6003100")]
	[Address(RVA = "0x1752504", Offset = "0x1752504", VA = "0x1752504")]
	private static void GetSceneParticles(List<KeyValuePair<string, List<KeyValuePair<ParticleSystem, int>>>> dst, StringBuilder prefix, Transform tr)
	{
	}

	[Token(Token = "0x6003101")]
	[Address(RVA = "0x1752CE4", Offset = "0x1752CE4", VA = "0x1752CE4")]
	private static void PrintParticlesList(StreamWriter sw, List<KeyValuePair<string, List<KeyValuePair<ParticleSystem, int>>>> list)
	{
	}

	[Token(Token = "0x6003102")]
	[Address(RVA = "0x1753650", Offset = "0x1753650", VA = "0x1753650")]
	public static void PrintUIRectChildrenCount()
	{
	}

	[Token(Token = "0x6003103")]
	[Address(RVA = "0x1753FC8", Offset = "0x1753FC8", VA = "0x1753FC8")]
	public static string OutputUmaCacheRefs()
	{
		return null;
	}

	[Token(Token = "0x6003104")]
	[Address(RVA = "0x1754190", Offset = "0x1754190", VA = "0x1754190")]
	private static int _003CWriteSizesToTxt_003Em__0(KeyValuePair<Object, int> p)
	{
		return default(int);
	}

	[Token(Token = "0x6003105")]
	[Address(RVA = "0x1754200", Offset = "0x1754200", VA = "0x1754200")]
	private static long _003CWriteSizesToTxt_003Em__1(KeyValuePair<Object, KeyValuePair<int, int>> p)
	{
		return default(long);
	}

	[Token(Token = "0x6003106")]
	[Address(RVA = "0x17542A4", Offset = "0x17542A4", VA = "0x17542A4")]
	private static long _003CWriteSizesToTxt_003Em__2(KeyValuePair<Object, KeyValuePair<int, int>> p)
	{
		return default(long);
	}

	[Token(Token = "0x6003107")]
	private static int _003CSortSizesDesc_00601_003Em__3<T>(KeyValuePair<T, int> a, KeyValuePair<T, int> b)
	{
		return default(int);
	}

	[Token(Token = "0x6003108")]
	private static int _003CSortSizesDesc_00601_003Em__4<T>(KeyValuePair<T, KeyValuePair<int, int>> a, KeyValuePair<T, KeyValuePair<int, int>> b)
	{
		return default(int);
	}
}
