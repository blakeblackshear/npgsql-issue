# -*- mode: ruby -*-
# vi: set ft=ruby :

# All Vagrant configuration is done below. The "2" in Vagrant.configure
# configures the configuration version (we support older styles for
# backwards compatibility). Please don't change it unless you know what
# you're doing.
Vagrant.configure(2) do |config|
  config.vm.box = "chef/centos-7.0"
  config.vm.synced_folder "./share", "/vagrant"

  config.vm.provision "shell", inline: <<-SHELL
    sudo yum install yum-utils -y
    sudo rpm --import "http://keyserver.ubuntu.com/pks/lookup?op=get&search=0x3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF"
    sudo yum-config-manager --add-repo http://download.mono-project.com/repo/centos/
    sudo yum install mono-complete -y
    xbuild /vagrant/NpgsqlSSL.sln
    mono /vagrant/NpgsqlSSL/bin/Debug/NpgsqlSSL.exe
  SHELL
end
