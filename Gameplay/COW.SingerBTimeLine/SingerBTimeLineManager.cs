using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.SingerBTimeLine;

[Token(Token = "0x2000B6A")]
public class SingerBTimeLineManager
{
	[Token(Token = "0x2000B6B")]
	private sealed class _003CDestroyAndUnloadTimeLine_003Ec__AnonStorey0
	{
		[Token(Token = "0x400610A")]
		[FieldOffset(Offset = "0x8")]
		internal string resIDName;

		[Token(Token = "0x400610B")]
		[FieldOffset(Offset = "0xC")]
		internal SingerBTimeLineManager _0024this;

		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x20EB560", Offset = "0x20EB560", VA = "0x20EB560")]
		public _003CDestroyAndUnloadTimeLine_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60056BE")]
		[Address(RVA = "0x20EB7B0", Offset = "0x20EB7B0", VA = "0x20EB7B0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4006105")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<uint, string> m_AsyncLoadTicketToLineResIDNameMap;

	[Token(Token = "0x4006106")]
	[FieldOffset(Offset = "0xC")]
	private string m_CurPendingPlayAsyncLoadTTimeLineResIDName;

	[Token(Token = "0x4006107")]
	[FieldOffset(Offset = "0x10")]
	private double m_CurPendingPlayAsyncLoadTimeLineClipStartTime;

	[Token(Token = "0x4006108")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, Object> m_FinishedLoadedTimeLineObject;

	[Token(Token = "0x4006109")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, GameObject> m_InstancedTimeLineGameObject;

	[Token(Token = "0x60056B4")]
	[Address(RVA = "0x20EB128", Offset = "0x20EB128", VA = "0x20EB128")]
	public SingerBTimeLineManager()
	{
	}

	[Token(Token = "0x60056B5")]
	[Address(RVA = "0x20E7710", Offset = "0x20E7710", VA = "0x20E7710")]
	public void AsyncLoadTimeLineByResIDName(string resIDName)
	{
	}

	[Token(Token = "0x60056B6")]
	[Address(RVA = "0x20EB264", Offset = "0x20EB264", VA = "0x20EB264")]
	public void OnTimeLineLoaded(uint ticket, bool succeeded, Object obj)
	{
	}

	[Token(Token = "0x60056B7")]
	[Address(RVA = "0x20EB438", Offset = "0x20EB438", VA = "0x20EB438")]
	private bool FindAsyncLoadedTimeLineToPlay(string resIDName, double clipStartTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60056B8")]
	[Address(RVA = "0x20EA2C4", Offset = "0x20EA2C4", VA = "0x20EA2C4")]
	public void TryPlaySubTimeLine(string resIDName, double subLineClipStartTime)
	{
	}

	[Token(Token = "0x60056B9")]
	[Address(RVA = "0x20E9E48", Offset = "0x20E9E48", VA = "0x20E9E48")]
	public void PlaySubTimeLineFromGameObject(GameObject lineObject, double subLineClipStartTime, string resIDName = "")
	{
	}

	[Token(Token = "0x60056BA")]
	[Address(RVA = "0x20E7D60", Offset = "0x20E7D60", VA = "0x20E7D60")]
	public void DestroyAndUnloadTimeLine(string resIDName, [Optional] GameObject destoryGameObject)
	{
	}

	[Token(Token = "0x60056BB")]
	[Address(RVA = "0x20EB568", Offset = "0x20EB568", VA = "0x20EB568")]
	private void UnloadTimeLine(string resIDName)
	{
	}

	[Token(Token = "0x60056BC")]
	[Address(RVA = "0x20E9844", Offset = "0x20E9844", VA = "0x20E9844")]
	public void PlayBGM(string bgmPrefabResIDStr, double subLineClipStartTime)
	{
	}
}
