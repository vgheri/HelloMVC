/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    grunt.initConfig({
        bower: {
            install: {
                options: {
                    targetDir: "wwwroot/lib",
                    layout: "byComponent",
                    cleanTargetDir: true
                }
            }
        },
        //grunt-contrib-less task:
        less: {
            development: {
                options: {
                    paths: ["Assets"],
                },
                files: { "wwwroot/css/site.css": "assets/site.less" }
            },
        }
    });

    grunt.registerTask("default", ["bower:install"]);
    
    grunt.loadNpmTasks("grunt-bower-task");

    grunt.loadNpmTasks("grunt-contrib-less");
};