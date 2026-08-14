using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace GCommon;

[Token(Token = "0x2003F74")]
public static class Mambet
{
	[Token(Token = "0x2003F75")]
	private class AudioBufferUnit<T>
	{
		[Token(Token = "0x401AC31")]
		[FieldOffset(Offset = "0x0")]
		public int ID;

		[Token(Token = "0x401AC32")]
		[FieldOffset(Offset = "0x0")]
		public T[] Data;

		[Token(Token = "0x401AC33")]
		[FieldOffset(Offset = "0x0")]
		public int BytesPerSample;

		[Token(Token = "0x401AC34")]
		[FieldOffset(Offset = "0x0")]
		public int Channels;

		[Token(Token = "0x401AC35")]
		[FieldOffset(Offset = "0x0")]
		public int SampleRate;

		[Token(Token = "0x401AC36")]
		[FieldOffset(Offset = "0x0")]
		public int Channel;

		[Token(Token = "0x6019D6D")]
		public AudioBufferUnit()
		{
		}
	}

	[Token(Token = "0x2003F76")]
	private class AudioBufferGroup<T>
	{
		[Token(Token = "0x401AC37")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, AudioBufferUnit<T>> _Busy;

		[Token(Token = "0x401AC38")]
		[FieldOffset(Offset = "0x0")]
		private Queue<AudioBufferUnit<T>> _Idle;

		[Token(Token = "0x6019D6E")]
		public AudioBufferGroup()
		{
		}

		[Token(Token = "0x6019D6F")]
		public AudioBufferUnit<T> Retrieve(int id)
		{
			return null;
		}

		[Token(Token = "0x6019D70")]
		public AudioBufferUnit<T> Occupy(int id, T[] data)
		{
			return null;
		}

		[Token(Token = "0x6019D71")]
		public void Release(int id)
		{
		}

		[Token(Token = "0x6019D72")]
		public void Clear()
		{
		}

		[Token(Token = "0x6019D73")]
		public string Status()
		{
			return null;
		}
	}

	[Token(Token = "0x2003F77")]
	private class AudioBuffer<T>
	{
		[Token(Token = "0x401AC39")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, AudioBufferGroup<T>> _Buffers;

		[Token(Token = "0x6019D74")]
		public AudioBuffer()
		{
		}

		[Token(Token = "0x6019D75")]
		public AudioBufferUnit<T> Retrieve(int id)
		{
			return null;
		}

		[Token(Token = "0x6019D76")]
		public AudioBufferUnit<T> Occupy(int id, T[] data)
		{
			return null;
		}

		[Token(Token = "0x6019D77")]
		public void Release(int id, int length)
		{
		}

		[Token(Token = "0x6019D78")]
		public void Clear()
		{
		}

		[Token(Token = "0x6019D79")]
		public string Status()
		{
			return null;
		}
	}

	[Token(Token = "0x2003F78")]
	private class UnityAudioCapturerWatcher : MonoBehaviour
	{
		[Token(Token = "0x2003F79")]
		private sealed class _003C_EnsureCapture_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
		{
			[Token(Token = "0x401AC3F")]
			[FieldOffset(Offset = "0x8")]
			internal object _0024current;

			[Token(Token = "0x401AC40")]
			[FieldOffset(Offset = "0xC")]
			internal bool _0024disposing;

			[Token(Token = "0x401AC41")]
			[FieldOffset(Offset = "0x10")]
			internal int _0024PC;

			[Token(Token = "0x17001C38")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6019D84")]
				[Address(RVA = "0x2968290", Offset = "0x2968290", VA = "0x2968290", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001C39")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6019D85")]
				[Address(RVA = "0x2968298", Offset = "0x2968298", VA = "0x2968298", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6019D82")]
			[Address(RVA = "0x2968154", Offset = "0x2968154", VA = "0x2968154")]
			public _003C_EnsureCapture_003Ec__Iterator0()
			{
			}

			[Token(Token = "0x6019D83")]
			[Address(RVA = "0x2968160", Offset = "0x2968160", VA = "0x2968160", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6019D86")]
			[Address(RVA = "0x29682A0", Offset = "0x29682A0", VA = "0x29682A0", Slot = "7")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6019D87")]
			[Address(RVA = "0x29682B4", Offset = "0x29682B4", VA = "0x29682B4", Slot = "6")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x401AC3A")]
		[FieldOffset(Offset = "0x0")]
		private static UnityAudioCapturerWatcher _I;

		[Token(Token = "0x401AC3B")]
		[FieldOffset(Offset = "0x4")]
		private static bool _ActiveSceneChanged;

		[Token(Token = "0x401AC3C")]
		[FieldOffset(Offset = "0x5")]
		private static bool _UnityAudioCapturerDestroyed;

		[Token(Token = "0x401AC3D")]
		[FieldOffset(Offset = "0x8")]
		private static UnityAction<Scene, Scene> _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x401AC3E")]
		[FieldOffset(Offset = "0xC")]
		private static UnityAction<Scene, Scene> _003C_003Ef__mg_0024cache1;

		[Token(Token = "0x6019D7A")]
		[Address(RVA = "0x2967C14", Offset = "0x2967C14", VA = "0x2967C14")]
		public UnityAudioCapturerWatcher()
		{
		}

		[Token(Token = "0x6019D7B")]
		[Address(RVA = "0x2963CE4", Offset = "0x2963CE4", VA = "0x2963CE4")]
		public static void Create()
		{
		}

		[Token(Token = "0x6019D7C")]
		[Address(RVA = "0x2967C1C", Offset = "0x2967C1C", VA = "0x2967C1C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6019D7D")]
		[Address(RVA = "0x2967D90", Offset = "0x2967D90", VA = "0x2967D90")]
		private static void OnActiveSceneChanged(Scene prev, Scene next)
		{
		}

		[Token(Token = "0x6019D7E")]
		[Address(RVA = "0x2967A30", Offset = "0x2967A30", VA = "0x2967A30")]
		public static void OnUnityAudioCapturerDestroy()
		{
		}

		[Token(Token = "0x6019D7F")]
		[Address(RVA = "0x2967ED8", Offset = "0x2967ED8", VA = "0x2967ED8")]
		private static void EnsureCapture()
		{
		}

		[Token(Token = "0x6019D80")]
		[Address(RVA = "0x29680E8", Offset = "0x29680E8", VA = "0x29680E8")]
		private static IEnumerator _EnsureCapture()
		{
			return null;
		}
	}

	[Token(Token = "0x2003F7A")]
	public class UnityAudioCapturer : MonoBehaviour
	{
		[Token(Token = "0x401AC42")]
		[FieldOffset(Offset = "0x0")]
		private static UnityAudioCapturer _I;

		[Token(Token = "0x401AC43")]
		[FieldOffset(Offset = "0x4")]
		public static Action<float[], int, int> OnCaptured;

		[Token(Token = "0x401AC44")]
		[FieldOffset(Offset = "0xC")]
		private int _OutputSampleRate;

		[Token(Token = "0x401AC45")]
		[FieldOffset(Offset = "0x8")]
		private static bool _Running;

		[Token(Token = "0x6019D88")]
		[Address(RVA = "0x2967598", Offset = "0x2967598", VA = "0x2967598")]
		public UnityAudioCapturer()
		{
		}

		[Token(Token = "0x6019D89")]
		[Address(RVA = "0x2963F74", Offset = "0x2963F74", VA = "0x2963F74")]
		public static void Create()
		{
		}

		[Token(Token = "0x6019D8A")]
		[Address(RVA = "0x29675A0", Offset = "0x29675A0", VA = "0x29675A0")]
		public static void EnsureCapture()
		{
		}

		[Token(Token = "0x6019D8B")]
		[Address(RVA = "0x29642F8", Offset = "0x29642F8", VA = "0x29642F8")]
		public static void Stop()
		{
		}

		[Token(Token = "0x6019D8C")]
		[Address(RVA = "0x29650A4", Offset = "0x29650A4", VA = "0x29650A4")]
		public static bool ShouldBeRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x6019D8D")]
		[Address(RVA = "0x296445C", Offset = "0x296445C", VA = "0x296445C")]
		public static bool IsRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x6019D8E")]
		[Address(RVA = "0x2967890", Offset = "0x2967890", VA = "0x2967890")]
		private void Update()
		{
		}

		[Token(Token = "0x6019D8F")]
		[Address(RVA = "0x29678AC", Offset = "0x29678AC", VA = "0x29678AC")]
		public void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x6019D90")]
		[Address(RVA = "0x296795C", Offset = "0x296795C", VA = "0x296795C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6019D91")]
		[Address(RVA = "0x2967B04", Offset = "0x2967B04", VA = "0x2967B04")]
		public void OnApplicationPause(bool paused)
		{
		}
	}

	[Token(Token = "0x2003F7B")]
	private class MambetHandler : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2003F7C")]
		public class AudioDataSent
		{
			[Token(Token = "0x401AC49")]
			[FieldOffset(Offset = "0x8")]
			public int id;

			[Token(Token = "0x401AC4A")]
			[FieldOffset(Offset = "0xC")]
			public int length;

			[Token(Token = "0x6019D9B")]
			[Address(RVA = "0x2967590", Offset = "0x2967590", VA = "0x2967590")]
			public AudioDataSent()
			{
			}
		}

		[Token(Token = "0x2003F7D")]
		private sealed class _003ConConnectChanged_003Ec__AnonStorey0
		{
			[Token(Token = "0x401AC4B")]
			[FieldOffset(Offset = "0x8")]
			internal string connectedStr;

			[Token(Token = "0x6019D9C")]
			[Address(RVA = "0x2966898", Offset = "0x2966898", VA = "0x2966898")]
			public _003ConConnectChanged_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6019D9D")]
			[Address(RVA = "0x2966FE8", Offset = "0x2966FE8", VA = "0x2966FE8")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x2003F7E")]
		private sealed class _003ConMicFocusChanged_003Ec__AnonStorey1
		{
			[Token(Token = "0x401AC4C")]
			[FieldOffset(Offset = "0x8")]
			internal string micFocusedStr;

			[Token(Token = "0x6019D9E")]
			[Address(RVA = "0x2966990", Offset = "0x2966990", VA = "0x2966990")]
			public _003ConMicFocusChanged_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x6019D9F")]
			[Address(RVA = "0x29672BC", Offset = "0x29672BC", VA = "0x29672BC")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x401AC46")]
		[FieldOffset(Offset = "0xC")]
		public bool _ApplicationPaused;

		[Token(Token = "0x401AC47")]
		[FieldOffset(Offset = "0xD")]
		public bool _ApplicationQuitting;

		[Token(Token = "0x401AC48")]
		[FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6019D92")]
		[Address(RVA = "0x296650C", Offset = "0x296650C", VA = "0x296650C")]
		public MambetHandler()
		{
		}

		[Token(Token = "0x6019D93")]
		[Address(RVA = "0x2966514", Offset = "0x2966514", VA = "0x2966514")]
		private void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6019D94")]
		[Address(RVA = "0x2966614", Offset = "0x2966614", VA = "0x2966614")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6019D95")]
		[Address(RVA = "0x29666AC", Offset = "0x29666AC", VA = "0x29666AC")]
		public void MambetDidUpdateCurrentlyStreamingNotification()
		{
		}

		[Token(Token = "0x6019D96")]
		[Address(RVA = "0x29667A8", Offset = "0x29667A8", VA = "0x29667A8")]
		public void onConnectChanged(string connectedStr)
		{
		}

		[Token(Token = "0x6019D97")]
		[Address(RVA = "0x29668A0", Offset = "0x29668A0", VA = "0x29668A0")]
		public void onMicFocusChanged(string micFocusedStr)
		{
		}

		[Token(Token = "0x6019D98")]
		[Address(RVA = "0x2966998", Offset = "0x2966998", VA = "0x2966998")]
		public void UnityAudioDataSent(string adsStr)
		{
		}

		[Token(Token = "0x6019D99")]
		[Address(RVA = "0x2966C14", Offset = "0x2966C14", VA = "0x2966C14")]
		public void ExternalAudioDataSent(string adsStr)
		{
		}

		[Token(Token = "0x6019D9A")]
		[Address(RVA = "0x2966E90", Offset = "0x2966E90", VA = "0x2966E90")]
		private static void _003CMambetDidUpdateCurrentlyStreamingNotification_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003F7F")]
	public enum ExternalAudioChannel
	{
		[Token(Token = "0x401AC4E")]
		Mic,
		[Token(Token = "0x401AC4F")]
		Remote,
		[Token(Token = "0x401AC50")]
		Mixed
	}

	[Token(Token = "0x401AC1B")]
	[FieldOffset(Offset = "0x0")]
	private static bool _VoiceDataSending;

	[Token(Token = "0x401AC1C")]
	[FieldOffset(Offset = "0x4")]
	private static AudioBuffer<float> _UnityAudioBuffers;

	[Token(Token = "0x401AC1D")]
	[FieldOffset(Offset = "0x8")]
	private static AudioBuffer<byte> _ExternalAudioBuffers;

	[Token(Token = "0x401AC1E")]
	[FieldOffset(Offset = "0xC")]
	public static Action<bool> OnConnectChanged;

	[Token(Token = "0x401AC1F")]
	[FieldOffset(Offset = "0x10")]
	public static Action<bool> OnMicFocusChanged;

	[Token(Token = "0x401AC20")]
	[FieldOffset(Offset = "0x14")]
	public static Action<int> OnUnityAudioCaptureCall;

	[Token(Token = "0x401AC21")]
	[FieldOffset(Offset = "0x18")]
	public static Action<string> OnLog;

	[Token(Token = "0x401AC22")]
	[FieldOffset(Offset = "0x1C")]
	public static Action<string> OnLogVerbose;

	[Token(Token = "0x401AC23")]
	[FieldOffset(Offset = "0x20")]
	private static MambetHandler _MambetHandler;

	[Token(Token = "0x401AC24")]
	private const string MAMBET_HANDLER_GAMEOBJECT_NAME = "MambetHandler";

	[Token(Token = "0x401AC25")]
	[FieldOffset(Offset = "0x24")]
	private static Thread _UnityAudioStreamThread;

	[Token(Token = "0x401AC26")]
	[FieldOffset(Offset = "0x28")]
	public static float UnityAudioCaptureOverhead_MS;

	[Token(Token = "0x401AC27")]
	[FieldOffset(Offset = "0x2C")]
	private static int _003CUnityAudioCaptureCalls_003Ek__BackingField;

	[Token(Token = "0x401AC28")]
	[FieldOffset(Offset = "0x30")]
	private static int _003CUnityAudioStreamNextID_003Ek__BackingField;

	[Token(Token = "0x401AC29")]
	[FieldOffset(Offset = "0x34")]
	private static Thread _ExternalAudioStreamThread;

	[Token(Token = "0x401AC2A")]
	[FieldOffset(Offset = "0x38")]
	private static bool _ExternalAudioCapturing;

	[Token(Token = "0x401AC2B")]
	[FieldOffset(Offset = "0x3C")]
	public static float ExternalAudioCaptureOverhead_MS;

	[Token(Token = "0x401AC2C")]
	[FieldOffset(Offset = "0x40")]
	private static int _003CExternalAudioCaptureCalls_003Ek__BackingField;

	[Token(Token = "0x401AC2D")]
	[FieldOffset(Offset = "0x44")]
	private static int _003CExternalAudioStreamNextID_003Ek__BackingField;

	[Token(Token = "0x401AC2E")]
	[FieldOffset(Offset = "0x48")]
	private static Action<float[], int, int> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x401AC2F")]
	[FieldOffset(Offset = "0x4C")]
	private static ThreadStart _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x401AC30")]
	[FieldOffset(Offset = "0x50")]
	private static ThreadStart _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x17001C34")]
	public static int UnityAudioCaptureCalls
	{
		[Token(Token = "0x6019D5E")]
		[Address(RVA = "0x2964528", Offset = "0x2964528", VA = "0x2964528")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019D5F")]
		[Address(RVA = "0x2963C54", Offset = "0x2963C54", VA = "0x2963C54")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C35")]
	public static int UnityAudioStreamNextID
	{
		[Token(Token = "0x6019D60")]
		[Address(RVA = "0x29645B4", Offset = "0x29645B4", VA = "0x29645B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019D61")]
		[Address(RVA = "0x296401C", Offset = "0x296401C", VA = "0x296401C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C36")]
	public static int ExternalAudioCaptureCalls
	{
		[Token(Token = "0x6019D67")]
		[Address(RVA = "0x2966078", Offset = "0x2966078", VA = "0x2966078")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019D68")]
		[Address(RVA = "0x29654A0", Offset = "0x29654A0", VA = "0x29654A0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C37")]
	public static int ExternalAudioStreamNextID
	{
		[Token(Token = "0x6019D69")]
		[Address(RVA = "0x2965CA0", Offset = "0x2965CA0", VA = "0x2965CA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019D6A")]
		[Address(RVA = "0x2965530", Offset = "0x2965530", VA = "0x2965530")]
		private set
		{
		}
	}

	[Token(Token = "0x6019D4E")]
	[Address(RVA = "0x2962770", Offset = "0x2962770", VA = "0x2962770")]
	public static void StartVoiceDataSender(bool debug_voice)
	{
	}

	[Token(Token = "0x6019D4F")]
	[Address(RVA = "0x2962934", Offset = "0x2962934", VA = "0x2962934")]
	public static void StopVoiceDataSender()
	{
	}

	[Token(Token = "0x6019D50")]
	[Address(RVA = "0x2962A64", Offset = "0x2962A64", VA = "0x2962A64")]
	public static bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x6019D51")]
	[Address(RVA = "0x2962AF0", Offset = "0x2962AF0", VA = "0x2962AF0")]
	public static void RequestMic()
	{
	}

	[Token(Token = "0x6019D52")]
	[Address(RVA = "0x2962B90", Offset = "0x2962B90", VA = "0x2962B90")]
	public static void ReleaseMic()
	{
	}

	[Token(Token = "0x6019D53")]
	[Address(RVA = "0x2962C30", Offset = "0x2962C30", VA = "0x2962C30")]
	public static string UnityAudioBufferStatus()
	{
		return null;
	}

	[Token(Token = "0x6019D54")]
	[Address(RVA = "0x2962DA0", Offset = "0x2962DA0", VA = "0x2962DA0")]
	public static string ExternalAudioBufferStatus()
	{
		return null;
	}

	[Token(Token = "0x6019D55")]
	[Address(RVA = "0x2962F10", Offset = "0x2962F10", VA = "0x2962F10")]
	private static void Log(string log)
	{
	}

	[Token(Token = "0x6019D56")]
	[Address(RVA = "0x296300C", Offset = "0x296300C", VA = "0x296300C")]
	private static void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6019D57")]
	[Address(RVA = "0x2963108", Offset = "0x2963108", VA = "0x2963108")]
	public static void Init(int game_id, bool debug_mode)
	{
	}

	[Token(Token = "0x6019D58")]
	[Address(RVA = "0x2963590", Offset = "0x2963590", VA = "0x2963590")]
	public static void SetAccountID(string accountID)
	{
	}

	[Token(Token = "0x6019D59")]
	[Address(RVA = "0x2963694", Offset = "0x2963694", VA = "0x2963694")]
	public static void PushEvent(string type, string data)
	{
	}

	[Token(Token = "0x6019D5A")]
	[Address(RVA = "0x29637EC", Offset = "0x29637EC", VA = "0x29637EC")]
	public static void StartCaptureUnityAudio()
	{
	}

	[Token(Token = "0x6019D5B")]
	[Address(RVA = "0x29640AC", Offset = "0x29640AC", VA = "0x29640AC")]
	public static void StopCaptureUnityAudio()
	{
	}

	[Token(Token = "0x6019D5C")]
	[Address(RVA = "0x2964454", Offset = "0x2964454", VA = "0x2964454")]
	public static void AfterSwitchScene()
	{
	}

	[Token(Token = "0x6019D5D")]
	[Address(RVA = "0x2964458", Offset = "0x2964458", VA = "0x2964458")]
	public static bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	[Token(Token = "0x6019D62")]
	[Address(RVA = "0x2964640", Offset = "0x2964640", VA = "0x2964640")]
	private static void OnUnityAudioCaptured(float[] sample, int channels, int sampleRate)
	{
	}

	[Token(Token = "0x6019D63")]
	[Address(RVA = "0x29649DC", Offset = "0x29649DC", VA = "0x29649DC")]
	private static void StreamUnityAudio()
	{
	}

	[Token(Token = "0x6019D64")]
	[Address(RVA = "0x2965108", Offset = "0x2965108", VA = "0x2965108")]
	public static void StartCaptureExternalAudio()
	{
	}

	[Token(Token = "0x6019D65")]
	[Address(RVA = "0x29655C0", Offset = "0x29655C0", VA = "0x29655C0")]
	public static void StopCaptureExternalAudio()
	{
	}

	[Token(Token = "0x6019D66")]
	[Address(RVA = "0x2965834", Offset = "0x2965834", VA = "0x2965834")]
	private static void StreamExternalAudio()
	{
	}

	[Token(Token = "0x6019D6B")]
	[Address(RVA = "0x2966104", Offset = "0x2966104", VA = "0x2966104")]
	public static void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, ExternalAudioChannel channel, int bytesPerSample)
	{
	}
}
