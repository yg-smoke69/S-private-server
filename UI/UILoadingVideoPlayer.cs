using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

[Token(Token = "0x2002910")]
public class UILoadingVideoPlayer : MonoBehaviour
{
	[Token(Token = "0x2002911")]
	private sealed class _003CLoadAndPrepare_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FCE0")]
		[FieldOffset(Offset = "0x8")]
		internal VideoClip _003Cclip_003E__0;

		[Token(Token = "0x400FCE1")]
		[FieldOffset(Offset = "0xC")]
		internal UILoadingVideoPlayer _0024this;

		[Token(Token = "0x400FCE2")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400FCE3")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400FCE4")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001216")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010484")]
			[Address(RVA = "0x148AB10", Offset = "0x148AB10", VA = "0x148AB10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001217")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010485")]
			[Address(RVA = "0x148AB18", Offset = "0x148AB18", VA = "0x148AB18", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010482")]
		[Address(RVA = "0x14894D0", Offset = "0x14894D0", VA = "0x14894D0")]
		public _003CLoadAndPrepare_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010483")]
		[Address(RVA = "0x148A024", Offset = "0x148A024", VA = "0x148A024", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010486")]
		[Address(RVA = "0x148AB20", Offset = "0x148AB20", VA = "0x148AB20", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010487")]
		[Address(RVA = "0x148AB34", Offset = "0x148AB34", VA = "0x148AB34", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FCD9")]
	[FieldOffset(Offset = "0xC")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400FCDA")]
	[FieldOffset(Offset = "0x10")]
	private UITexture uiTexture;

	[Token(Token = "0x400FCDB")]
	[FieldOffset(Offset = "0x14")]
	private AudioSource audioSource;

	[Token(Token = "0x400FCDC")]
	[FieldOffset(Offset = "0x18")]
	private RenderTexture renderTexture;

	[Token(Token = "0x400FCDD")]
	[FieldOffset(Offset = "0x1C")]
	private CustomVideoPlayer customVideoPlayer;

	[Token(Token = "0x400FCDE")]
	[FieldOffset(Offset = "0x20")]
	private bool isEnableCustomVideoPlayer;

	[Token(Token = "0x400FCDF")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<string, int> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x6010479")]
	[Address(RVA = "0x1488F98", Offset = "0x1488F98", VA = "0x1488F98")]
	public UILoadingVideoPlayer()
	{
	}

	[Token(Token = "0x601047A")]
	[Address(RVA = "0x1488FA0", Offset = "0x1488FA0", VA = "0x1488FA0")]
	private void InitEnableCustomVideoPlayer()
	{
	}

	[Token(Token = "0x601047B")]
	[Address(RVA = "0x1489264", Offset = "0x1489264", VA = "0x1489264")]
	private void Awake()
	{
	}

	[Token(Token = "0x601047C")]
	[Address(RVA = "0x14892F8", Offset = "0x14892F8", VA = "0x14892F8")]
	public void OnPauseVideo(bool paused)
	{
	}

	[Token(Token = "0x601047D")]
	[Address(RVA = "0x148944C", Offset = "0x148944C", VA = "0x148944C")]
	public IEnumerator LoadAndPrepare()
	{
		return null;
	}

	[Token(Token = "0x601047E")]
	[Address(RVA = "0x14894D8", Offset = "0x14894D8", VA = "0x14894D8")]
	public void SetupRenderer()
	{
	}

	[Token(Token = "0x601047F")]
	[Address(RVA = "0x1489A18", Offset = "0x1489A18", VA = "0x1489A18")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x6010480")]
	[Address(RVA = "0x1489B44", Offset = "0x1489B44", VA = "0x1489B44")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6010481")]
	[Address(RVA = "0x1489DF0", Offset = "0x1489DF0", VA = "0x1489DF0")]
	private void OnApplicationQuit()
	{
	}
}
