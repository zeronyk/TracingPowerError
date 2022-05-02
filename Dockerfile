FROM mono


COPY Program.cs /Program.cs
COPY init.sh /init.sh
COPY Skm.Holo.zip /Skm.Holo.zip

RUN apt-get update
RUN apt-get install unzip
#just for testcases since git modules does not work here
RUN unzip Skm.Holo.zip
#RUN unzip Skm.Shared.zip
#RUN ls
WORKDIR /Skm.Holo
#RUN ls
RUN nuget restore Skm.Holo.sln
RUN msbuild Skm.Holo.sln -p:Configuration=Release -p:Platform="Any CPU"

WORKDIR /

#CMD "bash" "/init_dummy.sh"
RUN mono-csc Program.cs -r:/Skm.Holo/Skm.Holo/bin/Release/net45/Skm.Holo.dll
ENV MONO_PATH=/Skm.Holo/Skm.Holo/bin/Release/net45/

RUN chmod +x /init.sh
CMD "bash" "/init.sh"
