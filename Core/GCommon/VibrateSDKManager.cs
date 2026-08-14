using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004183")]
internal class VibrateSDKManager
{
	[Token(Token = "0x2004184")]
	private enum ThreadRequestType
	{
		[Token(Token = "0x401B786")]
		None = -1,
		[Token(Token = "0x401B787")]
		Stop = 1,
		[Token(Token = "0x401B788")]
		Play = 2
	}

	[Token(Token = "0x2004185")]
	private class ThreadRequest
	{
		[Token(Token = "0x401B789")]
		[FieldOffset(Offset = "0x8")]
		public ThreadRequestType requestType;

		[Token(Token = "0x401B78A")]
		[FieldOffset(Offset = "0xC")]
		public VibrateSDKData requestCfg;

		[Token(Token = "0x601AC3D")]
		[Address(RVA = "0x2BD73B8", Offset = "0x2BD73B8", VA = "0x2BD73B8")]
		public ThreadRequest()
		{
		}
	}

	[Token(Token = "0x2004186")]
	public interface IVibrate
	{
		[Token(Token = "0x17001D87")]
		bool isHighQulity
		{
			[Token(Token = "0x601AC42")]
			get;
		}

		[Token(Token = "0x601AC3E")]
		void Init();

		[Token(Token = "0x601AC3F")]
		void Play(string heString, int loop, int amplitude);

		[Token(Token = "0x601AC40")]
		void Stop();

		[Token(Token = "0x601AC41")]
		void Quit();
	}

	[Token(Token = "0x2004187")]
	public class Vibrate_Android : _Attribute
	{
		[Token(Token = "0x401B78B")]
		[FieldOffset(Offset = "0x8")]
		private AndroidJavaObject m_Vibrate;

		[Token(Token = "0x401B78C")]
		[FieldOffset(Offset = "0xC")]
		private bool _003CisHighQulity_003Ek__BackingField;

		[Token(Token = "0x17001D88")]
		public bool isHighQulity
		{
			[Token(Token = "0x601AC48")]
			[Address(RVA = "0x2BD8F84", Offset = "0x2BD8F84", VA = "0x2BD8F84", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601AC49")]
			[Address(RVA = "0x2BD8F7C", Offset = "0x2BD8F7C", VA = "0x2BD8F7C")]
			private set
			{
			}
		}

		[Token(Token = "0x601AC43")]
		[Address(RVA = "0x2BD7120", Offset = "0x2BD7120", VA = "0x2BD7120")]
		public Vibrate_Android()
		{
		}

		[Token(Token = "0x601AC44")]
		[Address(RVA = "0x2BD8974", Offset = "0x2BD8974", VA = "0x2BD8974", Slot = "4")]
		public void Init()
		{
		}

		[Token(Token = "0x601AC45")]
		[Address(RVA = "0x2BD8F8C", Offset = "0x2BD8F8C", VA = "0x2BD8F8C", Slot = "5")]
		public void Play(string heString, int loop, int amplitude)
		{
		}

		[Token(Token = "0x601AC46")]
		[Address(RVA = "0x2BD92DC", Offset = "0x2BD92DC", VA = "0x2BD92DC", Slot = "6")]
		public void Stop()
		{
		}

		[Token(Token = "0x601AC47")]
		[Address(RVA = "0x2BD94C8", Offset = "0x2BD94C8", VA = "0x2BD94C8", Slot = "7")]
		public void Quit()
		{
		}
	}

	[Token(Token = "0x401B775")]
	[FieldOffset(Offset = "0x0")]
	private static VibrateSDKManager m_instance;

	[Token(Token = "0x401B776")]
	[FieldOffset(Offset = "0x4")]
	private static float m_maxDistForVibrate;

	[Token(Token = "0x401B777")]
	[FieldOffset(Offset = "0x8")]
	private Transform m_maxDistCameraTransform;

	[Token(Token = "0x401B778")]
	[FieldOffset(Offset = "0xC")]
	private IVibrate m_Vibrate;

	[Token(Token = "0x401B779")]
	[FieldOffset(Offset = "0x10")]
	private Thread m_PlayThread;

	[Token(Token = "0x401B77A")]
	[FieldOffset(Offset = "0x14")]
	private AutoResetEvent m_plsyVibrateEvent;

	[Token(Token = "0x401B77B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, VibrateSDKData> m_vibrateCfgDic;

	[Token(Token = "0x401B77C")]
	[FieldOffset(Offset = "0x1C")]
	private VibrateSDKData m_currRunEffectData;

	[Token(Token = "0x401B77D")]
	[FieldOffset(Offset = "0x20")]
	private VibrateSDKData m_currContinuousRunEffectData;

	[Token(Token = "0x401B77E")]
	[FieldOffset(Offset = "0x24")]
	private ThreadRequest m_threadRequest;

	[Token(Token = "0x401B77F")]
	[FieldOffset(Offset = "0x28")]
	private float m_currRunEffectStartTime;

	[Token(Token = "0x401B780")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, int> m_settingDic;

	[Token(Token = "0x401B781")]
	[FieldOffset(Offset = "0x30")]
	public bool isLocalPlayerDead;

	[Token(Token = "0x401B782")]
	[FieldOffset(Offset = "0x31")]
	private bool _003CisSupport_003Ek__BackingField;

	[Token(Token = "0x401B783")]
	[FieldOffset(Offset = "0x32")]
	private bool _003CisHighQulity_003Ek__BackingField;

	[Token(Token = "0x401B784")]
	[FieldOffset(Offset = "0x34")]
	private HashSet<int> m_disableGameVar;

	[Token(Token = "0x17001D82")]
	public static VibrateSDKManager instance
	{
		[Token(Token = "0x601AC24")]
		[Address(RVA = "0x2BD673C", Offset = "0x2BD673C", VA = "0x2BD673C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D83")]
	public bool isSupport
	{
		[Token(Token = "0x601AC25")]
		[Address(RVA = "0x2BD6864", Offset = "0x2BD6864", VA = "0x2BD6864")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AC26")]
		[Address(RVA = "0x2BD672C", Offset = "0x2BD672C", VA = "0x2BD672C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001D84")]
	public bool isHighQulity
	{
		[Token(Token = "0x601AC27")]
		[Address(RVA = "0x2BD686C", Offset = "0x2BD686C", VA = "0x2BD686C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AC28")]
		[Address(RVA = "0x2BD6734", Offset = "0x2BD6734", VA = "0x2BD6734")]
		private set
		{
		}
	}

	[Token(Token = "0x17001D85")]
	private bool vibrateEnabled
	{
		[Token(Token = "0x601AC2E")]
		[Address(RVA = "0x2BD7A24", Offset = "0x2BD7A24", VA = "0x2BD7A24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001D86")]
	private bool isMainSettingOpen
	{
		[Token(Token = "0x601AC3A")]
		[Address(RVA = "0x2BD7394", Offset = "0x2BD7394", VA = "0x2BD7394")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601AC23")]
	[Address(RVA = "0x2BD6068", Offset = "0x2BD6068", VA = "0x2BD6068")]
	public VibrateSDKManager()
	{
	}

	[Token(Token = "0x601AC29")]
	[Address(RVA = "0x2BD6874", Offset = "0x2BD6874", VA = "0x2BD6874")]
	public void Init()
	{
	}

	[Token(Token = "0x601AC2A")]
	[Address(RVA = "0x2BD73C8", Offset = "0x2BD73C8", VA = "0x2BD73C8")]
	private void UpdateVibrateDataSettingState()
	{
	}

	[Token(Token = "0x601AC2B")]
	[Address(RVA = "0x2BD770C", Offset = "0x2BD770C", VA = "0x2BD770C")]
	public void InitGameVibrate(Transform cameraTransform)
	{
	}

	[Token(Token = "0x601AC2C")]
	[Address(RVA = "0x2BD7754", Offset = "0x2BD7754", VA = "0x2BD7754")]
	private void StartVibrateThread()
	{
	}

	[Token(Token = "0x601AC2D")]
	[Address(RVA = "0x2BD78D8", Offset = "0x2BD78D8", VA = "0x2BD78D8")]
	public void ClearGameVibrate()
	{
	}

	[Token(Token = "0x601AC2F")]
	[Address(RVA = "0x2BD7A54", Offset = "0x2BD7A54", VA = "0x2BD7A54")]
	private void ThreadFunc()
	{
	}

	[Token(Token = "0x601AC30")]
	[Address(RVA = "0x2BD7E84", Offset = "0x2BD7E84", VA = "0x2BD7E84")]
	public void Play(int vibrateId)
	{
	}

	[Token(Token = "0x601AC31")]
	[Address(RVA = "0x2BD80F4", Offset = "0x2BD80F4", VA = "0x2BD80F4")]
	public void Play(int vibrateId, Vector3 worldPos)
	{
	}

	[Token(Token = "0x601AC32")]
	[Address(RVA = "0x2BD8034", Offset = "0x2BD8034", VA = "0x2BD8034")]
	private bool isCanPlay(VibrateSDKData newVibrate)
	{
		return default(bool);
	}

	[Token(Token = "0x601AC33")]
	[Address(RVA = "0x2BD8164", Offset = "0x2BD8164", VA = "0x2BD8164")]
	public bool WithinMaxDist(Vector3 worldPos)
	{
		return default(bool);
	}

	[Token(Token = "0x601AC34")]
	[Address(RVA = "0x2BD8314", Offset = "0x2BD8314", VA = "0x2BD8314")]
	public void Stop()
	{
	}

	[Token(Token = "0x601AC35")]
	[Address(RVA = "0x2BD83EC", Offset = "0x2BD83EC", VA = "0x2BD83EC")]
	public int PlayContinuous(int vibrateId)
	{
		return default(int);
	}

	[Token(Token = "0x601AC36")]
	[Address(RVA = "0x2BD85B4", Offset = "0x2BD85B4", VA = "0x2BD85B4")]
	public void StopContinuous(int vibrateId)
	{
	}

	[Token(Token = "0x601AC37")]
	[Address(RVA = "0x2BD85F4", Offset = "0x2BD85F4", VA = "0x2BD85F4")]
	public void OnResetSetting()
	{
	}

	[Token(Token = "0x601AC38")]
	[Address(RVA = "0x2BD86FC", Offset = "0x2BD86FC", VA = "0x2BD86FC")]
	public bool isVibrateSettingOpen(int vibrateId)
	{
		return default(bool);
	}

	[Token(Token = "0x601AC39")]
	[Address(RVA = "0x2BD75B4", Offset = "0x2BD75B4", VA = "0x2BD75B4")]
	private int GetSetting(int settingId)
	{
		return default(int);
	}

	[Token(Token = "0x601AC3B")]
	[Address(RVA = "0x2BD87E4", Offset = "0x2BD87E4", VA = "0x2BD87E4")]
	public void OnApplicationQuit()
	{
	}
}
