/*
* Copyright (c) <2020> Side Effects Software Inc.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*
* Produced by:
*      Side Effects Software Inc
*      123 Front Street West, Suite 1401
*      Toronto, Ontario
*      Canada   M5J 2M2
*      416-504-9876
*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// WARNING! This file is GENERATED by Unity_v2_generate_version.py.
// DO NOT modify manually or commit to the repository!
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace HoudiniEngineUnity
{

	public class HEU_HoudiniVersion
	{
		public const int HOUDINI_MAJOR			= 18;
		public const int HOUDINI_MINOR			= 5;
		public const int HOUDINI_BUILD			= 206;
		public const int HOUDINI_PATCH			= 0;

		public const string HOUDINI_VERSION_STRING = "18.5.206";

		public const int HOUDINI_ENGINE_MAJOR	= 3;
		public const int HOUDINI_ENGINE_MINOR	= 3;

		public const int HOUDINI_ENGINE_API		= 11;

		public const int UNITY_PLUGIN_VERSION	= 2;

#if UNITY_EDITOR_WIN || ( UNITY_METRO && UNITY_EDITOR ) || UNITY_STANDALONE_WIN

		public const string HAPI_BIN_PATH		= "/bin";

		#if UNITY_EDITOR_64 || UNITY_64
			public const string HAPI_LIBRARY	= "libHAPIL";
		#else
			public const string HAPI_LIBRARY	= "libHARC32";
		#endif // UNITY_EDITOR_64

        public const string SIDEFX_SOFTWARE_REGISTRY = "SOFTWARE\\Side Effects Software\\";

#elif UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX

		public const string HOUDINI_INSTALL_PATH = "/Applications/Houdini/Houdini" + HOUDINI_VERSION_STRING;
		public const string HOUDINI_FRAMEWORKS_PATH = "/Frameworks/Houdini.framework/Versions/Current";

		public const string HAPI_BIN_PATH		= HOUDINI_FRAMEWORKS_PATH + "/Resources/bin";
		public const string HAPI_LIBRARY_PATH		= HOUDINI_FRAMEWORKS_PATH + "/Libraries";

		#if UNITY_EDITOR_64 || UNITY_64
			public const string HAPI_LIBRARY	= HOUDINI_INSTALL_PATH + HAPI_LIBRARY_PATH + "/libHAPIL.dylib";
		#else
			public const string HAPI_LIBRARY	= HOUDINI_INSTALL_PATH + HAPI_LIBRARY_PATH + "/libHARC32.dylib";
		#endif // UNITY_EDITOR_64

#elif UNITY_STANDALONE_LINUX

		public const string HOUDINI_INSTALL_PATH	= "/opt/hfs" + HOUDINI_VERSION_STRING;

		public const string HAPI_BIN_PATH			= "/bin";
		public const string HAPI_LIBRARY_PATH		= "/dsolib";

		public const string HAPI_SERVER				= HOUDINI_INSTALL_PATH + HAPI_BIN_PATH + "/HARS";
		public const string HAPI_LIBRARY			= HOUDINI_INSTALL_PATH + HAPI_LIBRARY_PATH + "/libHAPIL.so";

#else

		// Unsupported platform: cannot be empty but its ok if not found.

		public const string HOUDINI_INSTALL_PATH	= "/opt/hfs" + HOUDINI_VERSION_STRING;

		public const string HAPI_BIN_PATH			= "/bin";
		public const string HAPI_LIBRARY_PATH		= "/dsolib";

		public const string HAPI_SERVER				= HOUDINI_INSTALL_PATH + HAPI_BIN_PATH + "/HARS";
		public const string HAPI_LIBRARY			= HOUDINI_INSTALL_PATH + HAPI_LIBRARY_PATH + "/libHAPIL.so";
#endif
	};

}	// HoudiniEngineUnity
