# A newer version should be fine
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")
git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet",
    branch = "master",
)

load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")
dotnet_repositories()

load(
    "@io_bazel_rules_dotnet//dotnet:defs.bzl",
    "dotnet_register_toolchains",
    "dotnet_repositories_nugets",
    "nuget_package"
)

dotnet_register_toolchains()
dotnet_repositories_nugets()
### Generated by the tool
nuget_package(
    name = "system.io",
    package = "system.io",
    version = "4.3.0",
    sha256 = "aeeca74077a414fe703eb0e257284d891217799fc8f4da632b9a54f873c38916",
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.5/System.IO.dll",
        "netcoreapp2.1": "ref/netstandard1.5/System.IO.dll",
        "netcoreapp2.2": "ref/netstandard1.5/System.IO.dll",
        "netcoreapp3.0": "ref/netstandard1.5/System.IO.dll",
        "netcoreapp3.1": "ref/netstandard1.5/System.IO.dll",
        "net5.0": "ref/netstandard1.5/System.IO.dll",
        "net6.0": "ref/netstandard1.5/System.IO.dll",
    },
)
nuget_package(
    name = "system.runtime",
    package = "system.runtime",
    version = "4.3.1",
    sha256 = "47d4faf00cd2d4f249eefe80473f6fa3cf2928bd5d5aa2ce00d838a64423900d",
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.5/System.Runtime.dll",
        "netcoreapp2.1": "ref/netstandard1.5/System.Runtime.dll",
        "netcoreapp2.2": "ref/netstandard1.5/System.Runtime.dll",
        "netcoreapp3.0": "ref/netstandard1.5/System.Runtime.dll",
        "netcoreapp3.1": "ref/netstandard1.5/System.Runtime.dll",
        "net5.0": "ref/netstandard1.5/System.Runtime.dll",
        "net6.0": "ref/netstandard1.5/System.Runtime.dll",
    },
)
nuget_package(
    name = "system.runtime.compilerservices.unsafe",
    package = "system.runtime.compilerservices.unsafe",
    version = "4.7.1",
    sha256 = "52fca80d5f0ed286371cf1b519b039e9855dbf04c611f8d8479816d4eec82b85",
    core_lib = {
        "netcoreapp2.0": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.1": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.2": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.0": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.1": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net5.0": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net6.0": "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    core_ref = {
        "netcoreapp2.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.1": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.2": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp3.1": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net5.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net6.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    core_files = {
        "netcoreapp2.0": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp2.1": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp2.2": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp3.0": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp3.1": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net5.0": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net6.0": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
    },
)
nuget_package(
    name = "system.security.cryptography.encoding",
    package = "system.security.cryptography.encoding",
    version = "4.3.0",
    sha256 = "62e81ef3d37a33e35c6e572f5cc7b21d9ea46437f006fdcb3cc0e217c1e126cb",
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        "netcoreapp2.1": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        "netcoreapp2.2": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        "netcoreapp3.0": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        "netcoreapp3.1": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        "net5.0": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        "net6.0": "ref/netstandard1.3/System.Security.Cryptography.Encoding.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.runtime//:netcoreapp2.0_core",
        ],
        "netcoreapp2.1": [
           "@system.runtime//:netcoreapp2.1_core",
        ],
        "netcoreapp2.2": [
           "@system.runtime//:netcoreapp2.2_core",
        ],
        "netcoreapp3.0": [
           "@system.runtime//:netcoreapp3.0_core",
        ],
        "netcoreapp3.1": [
           "@system.runtime//:netcoreapp3.1_core",
        ],
        "net5.0": [
           "@system.runtime//:net5.0_core",
        ],
        "net6.0": [
           "@system.runtime//:net6.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
        "netcoreapp2.1": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
        "netcoreapp2.2": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
        "netcoreapp3.0": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
        "netcoreapp3.1": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
        "net5.0": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
        "net6.0": [
           "runtimes/unix/lib/netstandard1.3/System.Security.Cryptography.Encoding.dll",
        ],
    },
)
nuget_package(
    name = "system.security.cryptography.primitives",
    package = "system.security.cryptography.primitives",
    version = "4.3.0",
    sha256 = "7e7162ec1dd29d58f96be05b8179db8e718dbd6ac2114e87a7fc23b235b3df5f",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp2.1": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp2.2": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp3.0": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp3.1": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "net5.0": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "net6.0": "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
    },
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp2.1": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp2.2": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp3.0": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "netcoreapp3.1": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "net5.0": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        "net6.0": "ref/netstandard1.3/System.Security.Cryptography.Primitives.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.io//:netcoreapp2.0_core",
           "@system.runtime//:netcoreapp2.0_core",
        ],
        "netcoreapp2.1": [
           "@system.io//:netcoreapp2.1_core",
           "@system.runtime//:netcoreapp2.1_core",
        ],
        "netcoreapp2.2": [
           "@system.io//:netcoreapp2.2_core",
           "@system.runtime//:netcoreapp2.2_core",
        ],
        "netcoreapp3.0": [
           "@system.io//:netcoreapp3.0_core",
           "@system.runtime//:netcoreapp3.0_core",
        ],
        "netcoreapp3.1": [
           "@system.io//:netcoreapp3.1_core",
           "@system.runtime//:netcoreapp3.1_core",
        ],
        "net5.0": [
           "@system.io//:net5.0_core",
           "@system.runtime//:net5.0_core",
        ],
        "net6.0": [
           "@system.io//:net6.0_core",
           "@system.runtime//:net6.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
        "netcoreapp2.1": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
        "netcoreapp2.2": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
        "netcoreapp3.0": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
        "netcoreapp3.1": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
        "net5.0": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
        "net6.0": [
           "lib/netstandard1.3/System.Security.Cryptography.Primitives.dll",
        ],
    },
)
nuget_package(
    name = "system.security.cryptography.algorithms",
    package = "system.security.cryptography.algorithms",
    version = "4.3.1",
    sha256 = "4253bfa69464fcec836070a2983f3aed102528839a922743d0808d3adeb75cd4",
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        "netcoreapp2.1": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        "netcoreapp2.2": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        "netcoreapp3.0": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        "netcoreapp3.1": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        "net5.0": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        "net6.0": "ref/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.io//:netcoreapp2.0_core",
           "@system.runtime//:netcoreapp2.0_core",
           "@system.security.cryptography.encoding//:netcoreapp2.0_core",
           "@system.security.cryptography.primitives//:netcoreapp2.0_core",
        ],
        "netcoreapp2.1": [
           "@system.io//:netcoreapp2.1_core",
           "@system.runtime//:netcoreapp2.1_core",
           "@system.security.cryptography.encoding//:netcoreapp2.1_core",
           "@system.security.cryptography.primitives//:netcoreapp2.1_core",
        ],
        "netcoreapp2.2": [
           "@system.io//:netcoreapp2.2_core",
           "@system.runtime//:netcoreapp2.2_core",
           "@system.security.cryptography.encoding//:netcoreapp2.2_core",
           "@system.security.cryptography.primitives//:netcoreapp2.2_core",
        ],
        "netcoreapp3.0": [
           "@system.io//:netcoreapp3.0_core",
           "@system.runtime//:netcoreapp3.0_core",
           "@system.security.cryptography.encoding//:netcoreapp3.0_core",
           "@system.security.cryptography.primitives//:netcoreapp3.0_core",
        ],
        "netcoreapp3.1": [
           "@system.io//:netcoreapp3.1_core",
           "@system.runtime//:netcoreapp3.1_core",
           "@system.security.cryptography.encoding//:netcoreapp3.1_core",
           "@system.security.cryptography.primitives//:netcoreapp3.1_core",
        ],
        "net5.0": [
           "@system.io//:net5.0_core",
           "@system.runtime//:net5.0_core",
           "@system.security.cryptography.encoding//:net5.0_core",
           "@system.security.cryptography.primitives//:net5.0_core",
        ],
        "net6.0": [
           "@system.io//:net6.0_core",
           "@system.runtime//:net6.0_core",
           "@system.security.cryptography.encoding//:net6.0_core",
           "@system.security.cryptography.primitives//:net6.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
        "netcoreapp2.1": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
        "netcoreapp2.2": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
        "netcoreapp3.0": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
        "netcoreapp3.1": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
        "net5.0": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
        "net6.0": [
           "runtimes/osx/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.Algorithms.dll",
        ],
    },
)
nuget_package(
    name = "system.security.cryptography.x509certificates",
    package = "system.security.cryptography.x509certificates",
    version = "4.3.2",
    sha256 = "b24680b48aa291b06fd79f3a1287128b083e42a06cf6de6329402bfd06fdca2d",
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
        "netcoreapp2.1": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
        "netcoreapp2.2": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
        "netcoreapp3.0": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
        "netcoreapp3.1": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
        "net5.0": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
        "net6.0": "ref/netstandard1.4/System.Security.Cryptography.X509Certificates.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.io//:netcoreapp2.0_core",
           "@system.runtime//:netcoreapp2.0_core",
           "@system.security.cryptography.algorithms//:netcoreapp2.0_core",
           "@system.security.cryptography.encoding//:netcoreapp2.0_core",
           "@system.security.cryptography.primitives//:netcoreapp2.0_core",
        ],
        "netcoreapp2.1": [
           "@system.io//:netcoreapp2.1_core",
           "@system.runtime//:netcoreapp2.1_core",
           "@system.security.cryptography.algorithms//:netcoreapp2.1_core",
           "@system.security.cryptography.encoding//:netcoreapp2.1_core",
           "@system.security.cryptography.primitives//:netcoreapp2.1_core",
        ],
        "netcoreapp2.2": [
           "@system.io//:netcoreapp2.2_core",
           "@system.runtime//:netcoreapp2.2_core",
           "@system.security.cryptography.algorithms//:netcoreapp2.2_core",
           "@system.security.cryptography.encoding//:netcoreapp2.2_core",
           "@system.security.cryptography.primitives//:netcoreapp2.2_core",
        ],
        "netcoreapp3.0": [
           "@system.io//:netcoreapp3.0_core",
           "@system.runtime//:netcoreapp3.0_core",
           "@system.security.cryptography.algorithms//:netcoreapp3.0_core",
           "@system.security.cryptography.encoding//:netcoreapp3.0_core",
           "@system.security.cryptography.primitives//:netcoreapp3.0_core",
        ],
        "netcoreapp3.1": [
           "@system.io//:netcoreapp3.1_core",
           "@system.runtime//:netcoreapp3.1_core",
           "@system.security.cryptography.algorithms//:netcoreapp3.1_core",
           "@system.security.cryptography.encoding//:netcoreapp3.1_core",
           "@system.security.cryptography.primitives//:netcoreapp3.1_core",
        ],
        "net5.0": [
           "@system.io//:net5.0_core",
           "@system.runtime//:net5.0_core",
           "@system.security.cryptography.algorithms//:net5.0_core",
           "@system.security.cryptography.encoding//:net5.0_core",
           "@system.security.cryptography.primitives//:net5.0_core",
        ],
        "net6.0": [
           "@system.io//:net6.0_core",
           "@system.runtime//:net6.0_core",
           "@system.security.cryptography.algorithms//:net6.0_core",
           "@system.security.cryptography.encoding//:net6.0_core",
           "@system.security.cryptography.primitives//:net6.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
        "netcoreapp2.1": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
        "netcoreapp2.2": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
        "netcoreapp3.0": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
        "netcoreapp3.1": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
        "net5.0": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
        "net6.0": [
           "runtimes/unix/lib/netstandard1.6/System.Security.Cryptography.X509Certificates.dll",
        ],
    },
)
nuget_package(
    name = "system.net.http",
    package = "system.net.http",
    version = "4.3.4",
    sha256 = "14ca14d0aee794f2f1a038eed0d2f6d568e581af46a67028423b05845618b74d",
    core_ref = {
        "netcoreapp2.0": "ref/netstandard1.3/System.Net.Http.dll",
        "netcoreapp2.1": "ref/netstandard1.3/System.Net.Http.dll",
        "netcoreapp2.2": "ref/netstandard1.3/System.Net.Http.dll",
        "netcoreapp3.0": "ref/netstandard1.3/System.Net.Http.dll",
        "netcoreapp3.1": "ref/netstandard1.3/System.Net.Http.dll",
        "net5.0": "ref/netstandard1.3/System.Net.Http.dll",
        "net6.0": "ref/netstandard1.3/System.Net.Http.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.io//:netcoreapp2.0_core",
           "@system.runtime//:netcoreapp2.0_core",
           "@system.security.cryptography.algorithms//:netcoreapp2.0_core",
           "@system.security.cryptography.encoding//:netcoreapp2.0_core",
           "@system.security.cryptography.primitives//:netcoreapp2.0_core",
           "@system.security.cryptography.x509certificates//:netcoreapp2.0_core",
        ],
        "netcoreapp2.1": [
           "@system.io//:netcoreapp2.1_core",
           "@system.runtime//:netcoreapp2.1_core",
           "@system.security.cryptography.algorithms//:netcoreapp2.1_core",
           "@system.security.cryptography.encoding//:netcoreapp2.1_core",
           "@system.security.cryptography.primitives//:netcoreapp2.1_core",
           "@system.security.cryptography.x509certificates//:netcoreapp2.1_core",
        ],
        "netcoreapp2.2": [
           "@system.io//:netcoreapp2.2_core",
           "@system.runtime//:netcoreapp2.2_core",
           "@system.security.cryptography.algorithms//:netcoreapp2.2_core",
           "@system.security.cryptography.encoding//:netcoreapp2.2_core",
           "@system.security.cryptography.primitives//:netcoreapp2.2_core",
           "@system.security.cryptography.x509certificates//:netcoreapp2.2_core",
        ],
        "netcoreapp3.0": [
           "@system.io//:netcoreapp3.0_core",
           "@system.runtime//:netcoreapp3.0_core",
           "@system.security.cryptography.algorithms//:netcoreapp3.0_core",
           "@system.security.cryptography.encoding//:netcoreapp3.0_core",
           "@system.security.cryptography.primitives//:netcoreapp3.0_core",
           "@system.security.cryptography.x509certificates//:netcoreapp3.0_core",
        ],
        "netcoreapp3.1": [
           "@system.io//:netcoreapp3.1_core",
           "@system.runtime//:netcoreapp3.1_core",
           "@system.security.cryptography.algorithms//:netcoreapp3.1_core",
           "@system.security.cryptography.encoding//:netcoreapp3.1_core",
           "@system.security.cryptography.primitives//:netcoreapp3.1_core",
           "@system.security.cryptography.x509certificates//:netcoreapp3.1_core",
        ],
        "net5.0": [
           "@system.io//:net5.0_core",
           "@system.runtime//:net5.0_core",
           "@system.security.cryptography.algorithms//:net5.0_core",
           "@system.security.cryptography.encoding//:net5.0_core",
           "@system.security.cryptography.primitives//:net5.0_core",
           "@system.security.cryptography.x509certificates//:net5.0_core",
        ],
        "net6.0": [
           "@system.io//:net6.0_core",
           "@system.runtime//:net6.0_core",
           "@system.security.cryptography.algorithms//:net6.0_core",
           "@system.security.cryptography.encoding//:net6.0_core",
           "@system.security.cryptography.primitives//:net6.0_core",
           "@system.security.cryptography.x509certificates//:net6.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
        "netcoreapp2.1": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
        "netcoreapp2.2": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
        "netcoreapp3.0": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
        "netcoreapp3.1": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
        "net5.0": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
        "net6.0": [
           "runtimes/unix/lib/netstandard1.6/System.Net.Http.dll",
        ],
    },
)
nuget_package(
    name = "system.threading.tasks.extensions",
    package = "system.threading.tasks.extensions",
    version = "4.5.4",
    sha256 = "a304a963cc0796c5179f9c6b7d8022bbce3b2fa7c029eb6196f631f7b462d678",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.runtime.compilerservices.unsafe//:netcoreapp2.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "lib/netstandard2.0/System.Threading.Tasks.Extensions.dll",
           "lib/netstandard2.0/System.Threading.Tasks.Extensions.xml",
        ],
    },
)
nuget_package(
    name = "fluentassertions",
    package = "fluentassertions",
    version = "6.5.1",
    sha256 = "c587d6a654a0c723f1f7d05a428b00091e05d33b29d1a58052c45a255488a95c",
    core_lib = {
        "netcoreapp2.0": "lib/netstandard2.0/FluentAssertions.dll",
        "netcoreapp2.1": "lib/netcoreapp2.1/FluentAssertions.dll",
        "netcoreapp2.2": "lib/netcoreapp2.1/FluentAssertions.dll",
        "netcoreapp3.0": "lib/netcoreapp3.0/FluentAssertions.dll",
        "netcoreapp3.1": "lib/netcoreapp3.0/FluentAssertions.dll",
        "net5.0": "lib/netcoreapp3.0/FluentAssertions.dll",
        "net6.0": "lib/netcoreapp3.0/FluentAssertions.dll",
    },
    core_deps = {
        "netcoreapp2.0": [
           "@system.threading.tasks.extensions//:netcoreapp2.0_core",
        ],
    },
    core_files = {
        "netcoreapp2.0": [
           "lib/netstandard2.0/FluentAssertions.dll",
           "lib/netstandard2.0/FluentAssertions.pdb",
           "lib/netstandard2.0/FluentAssertions.xml",
        ],
        "netcoreapp2.1": [
           "lib/netcoreapp2.1/FluentAssertions.dll",
           "lib/netcoreapp2.1/FluentAssertions.pdb",
           "lib/netcoreapp2.1/FluentAssertions.xml",
        ],
        "netcoreapp2.2": [
           "lib/netcoreapp2.1/FluentAssertions.dll",
           "lib/netcoreapp2.1/FluentAssertions.pdb",
           "lib/netcoreapp2.1/FluentAssertions.xml",
        ],
        "netcoreapp3.0": [
           "lib/netcoreapp3.0/FluentAssertions.dll",
           "lib/netcoreapp3.0/FluentAssertions.pdb",
           "lib/netcoreapp3.0/FluentAssertions.xml",
        ],
        "netcoreapp3.1": [
           "lib/netcoreapp3.0/FluentAssertions.dll",
           "lib/netcoreapp3.0/FluentAssertions.pdb",
           "lib/netcoreapp3.0/FluentAssertions.xml",
        ],
        "net5.0": [
           "lib/netcoreapp3.0/FluentAssertions.dll",
           "lib/netcoreapp3.0/FluentAssertions.pdb",
           "lib/netcoreapp3.0/FluentAssertions.xml",
        ],
        "net6.0": [
           "lib/netcoreapp3.0/FluentAssertions.dll",
           "lib/netcoreapp3.0/FluentAssertions.pdb",
           "lib/netcoreapp3.0/FluentAssertions.xml",
        ],
    },
)
### End of generated by the tool
